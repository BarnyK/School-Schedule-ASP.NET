using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace EguiProject2.Models
{
    public class ActivityStorage{
        // Model used to store activity data and serialize it into json files
        static public List<string> Hours = new List<string>(){
            "8:00 - 8:45", "8:55 - 9:40", "9:50 - 11:35", 
            "11:55 - 12:40", "12:50 - 13:35", "13:45 - 14:30",
            "14:40 - 15:25", "15:35 - 16:20", "16:30 - 17:15", 
        };
        static public List<string> Days = new List<string>(){
            "Monday","Tuesday","Wednesday","Thursday","Friday"
        };
        public List<string> rooms{get;set;}
        public List<string> groups{get;set;}
        public List<string> teachers{get;set;}
        public List<string> classes{get;set;}
        public List<Activit> activities{get;set;}

        public ActivityStorage(){
            rooms = new List<string>();
            groups = new List<string>();
            teachers = new List<string>();
            classes = new List<string>();
            activities = new List<Activit>();
        }

        public bool ImportDataFromJson(string text){
            try{
                ActivityStorage x = JsonSerializer.Deserialize<ActivityStorage>(text);
                rooms = x.rooms;
                groups = x.groups;
                teachers = x.teachers;
                classes = x.classes;
                activities = x.activities;
                return true;
            }catch(Exception){
                return false;
            }
        }

        public byte[] ExportBytes(){
            return JsonSerializer.SerializeToUtf8Bytes(this);
        }

        public Activit[,] GetRoomMatrix(string room){
            Activit[,] matrix = new Activit[5,9];
            Activit x;
            if(rooms.Exists(x => x == room)){
                for(int i=0; i < activities.Count ;i++){
                    x = activities[i];
                    if(x.room == room){
                        matrix[x.day,x.slot] = x;
                    }
                }
            }
            return matrix;
        }

        public int GetActivityIndex(string room, int day, int slot){
            Activit x;
            for(int i=0; i < activities.Count ;i++){
                    x = activities[i];
                    if(x.room == room && x.day == day && x.slot == slot){
                        return i;
                    }
                }
            return -1;
        }

        public Activit GetActivity(string room, int day, int slot){
            int i = GetActivityIndex(room, day, slot);
            if(i != -1){
                return activities[i];
            }
            return null;
        }

        public void EditOrAddActivity(string room, int day, int slot, string group, string teacher, string topic){
             int i = GetActivityIndex(room, day, slot);
             if(i != -1){
                 activities[i] = new Activit(room,day,slot,group,teacher,topic);
             }
             else{
                 activities.Add(new Activit(room,day,slot,group,teacher,topic));
             }
        }

        public void RemoveActivity(string room, int day, int slot){
            int i = GetActivityIndex(room, day, slot);
            if(i != -1){
                activities.RemoveAt(i);
            }
        }
    
    }
}
