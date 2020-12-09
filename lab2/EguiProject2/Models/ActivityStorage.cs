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
        public List<string> Rooms{get;set;}
        public List<string> Groups{get;set;}
        public List<string> Teachers{get;set;}
        public List<string> Topics{get;set;}
        public List<Activit> Activities{get;set;}

        public ActivityStorage(){
            Rooms = new List<string>();
            Groups = new List<string>();
            Teachers = new List<string>();
            Topics = new List<string>();
            Activities = new List<Activit>();
        }

        public bool ImportDataFromJson(string text){
            try{
                ActivityStorage x = JsonSerializer.Deserialize<ActivityStorage>(text);
                Rooms = x.Rooms;
                Groups = x.Groups;
                Teachers = x.Teachers;
                Topics = x.Topics;
                Activities = x.Activities;
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
            if(Rooms.Exists(x => x == room)){
                for(int i=0; i < Activities.Count ;i++){
                    x = Activities[i];
                    if(x.Room == room){
                        matrix[x.Day,x.Slot] = x;
                    }
                }
            }
            return matrix;
        }

        public int GetActivityIndex(string room, int day, int slot){
            Activit x;
            for(int i=0; i < Activities.Count ;i++){
                    x = Activities[i];
                    if(x.Room == room && x.Day == day && x.Slot == slot){
                        return i;
                    }
                }
            return -1;
        }

        public Activit GetActivity(string room, int day, int slot){
            int i = GetActivityIndex(room, day, slot);
            if(i != -1){
                return Activities[i];
            }
            return null;
        }

        public void EditOrAddActivity(string room, int day, int slot, string group, string teacher, string topic){
             int i = GetActivityIndex(room, day, slot);
             if(i != -1){
                 Activities[i] = new Activit(room,day,slot,group,teacher,topic);
             }
             else{
                 Activities.Add(new Activit(room,day,slot,group,teacher,topic));
             }
        }

        public void RemoveActivity(string room, int day, int slot){
            int i = GetActivityIndex(room, day, slot);
            if(i != -1){
                Activities.RemoveAt(i);
            }
        }
    
    }
}
