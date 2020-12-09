using System;
using System.ComponentModel.DataAnnotations;

namespace EguiProject2.Models
{
    public class Activit{
        public int Slot{ get; set; }
        public int Day{ get; set; }
        public string Teacher{ get; set; }
        public string Group{ get; set; }
        public string Room{ get; set; }
        public string Topic{ get; set; }
        
        public Activit(string room, int day, int slot, string group, string teacher, string topic){
            Room = room;
            Day = day;
            Slot = slot;
            Group = group;
            Teacher = teacher;
            Topic = topic;
        }
    }
}
