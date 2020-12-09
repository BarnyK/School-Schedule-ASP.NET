using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Encodings.Web;
using EguiProject2.Models;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace EguiProject2.Controllers
{
    public class ActivitiesController : Controller
    {
        static private ActivityStorage Data = new ActivityStorage();
        public IActionResult Index(string room)
        {
            // View of table
            ViewData["Hours"] = ActivityStorage.Hours;
            ViewData["Days"] = ActivityStorage.Days;
            ViewData["Rooms"] = Data.Rooms;
            if(room is not null){
                ViewData["CurrentRoom"] = room;
            }
            else{
                if(Data.Rooms.Count > 0){
                    ViewData["CurrentRoom"] = Data.Rooms[0];
                }
                else{
                    // Signals to view that there is no rooms
                    ViewData["CurrentRoom"] = "";
                }
            }
            ViewData["Activities"] = Data.GetRoomMatrix((string)ViewData["CurrentRoom"]);

            return View();
        }

        public IActionResult EditLists(){
            ViewData["Rooms"] = Data.Rooms;
            ViewData["Groups"] = Data.Groups;
            ViewData["Teachers"] = Data.Teachers;
            ViewData["Topics"] = Data.Topics;
            return View();
        }

        [HttpPost]
        public IActionResult AddToList(string list, string text){
            switch (list){
                case "Rooms":
                    if(!Data.Rooms.Exists(x => x == text))
                        Data.Rooms.Add(text);
                    break;
                case "Groups":
                    if(!Data.Groups.Exists(x => x == text))
                        Data.Groups.Add(text);
                    break;
                case "Teachers":
                    if(!Data.Teachers.Exists(x => x == text))
                        Data.Teachers.Add(text);
                    break;
                case "Topics":
                    if(!Data.Topics.Exists(x => x == text))
                        Data.Topics.Add(text);
                    break;
                default:
                    break;
            }
            return Redirect("/Activities/EditLists");
        }
        [HttpPost]
        public IActionResult RemoveFromList(string list, string listItem){
            switch (list){
                case "Rooms":
                    Data.Rooms.Remove(listItem);
                    break;
                case "Groups":
                    Data.Groups.Remove(listItem);
                    break;
                case "Teachers":
                    Data.Teachers.Remove(listItem);
                    break;
                case "Topics":
                    Data.Topics.Remove(listItem);
                    break;
                default:
                    break;
            }
            return Redirect("/Activities/EditLists");
        }

        [HttpGet]
        public IActionResult EditActivity(int slot, int day, string room){
            try{
                ViewData["DayId"] = day;
                ViewData["Day"] = ActivityStorage.Days[day];
                ViewData["Slot"] = slot;
                ViewData["Hour"] = ActivityStorage.Hours[slot];
                if(!Data.Rooms.Exists(x => x == room))
                    throw new Exception();
                ViewData["Room"] = room;
            }catch(Exception){
                return Redirect("/Activities/ErrorView");
            }

            ViewData["Activity"] = Data.GetActivity(room, day, slot);
            return View(Data);
        }

        [HttpPost]
        public IActionResult EditActivity(int slot, int day, string room, string group, string teacher, string topic){
            Data.EditOrAddActivity(room,day,slot,group,teacher,topic);
            return RedirectToAction("Index", new { room=room});
        }

        [HttpPost]
        public IActionResult RemoveActivity(string room, int slot, int day){
            Data.RemoveActivity(room,day,slot);
            return RedirectToAction("Index", new { room=room});
        }

    
        [HttpGet]
        public IActionResult ImportExport(){
            return View();
        }

        [HttpPost]
        public FileContentResult ExportData(){
            byte[] jsonBytes = Data.ExportBytes();
            FileContentResult x = new FileContentResult(jsonBytes, "plain/text");
            x.FileDownloadName = "data.json";
            return x;
        }
        
        [HttpPost]
        public IActionResult ImportData(IFormFile file){
            string result = "";
            if(file is not null){
                using( var reader = new StreamReader(file.OpenReadStream())){
                    result = reader.ReadToEnd();
                }
                Data.ImportDataFromJson(result);
            }
            return Redirect("/Activities/Index");
        }

        public IActionResult ErrorView(string message){
            return View();
        }
        
    }
}