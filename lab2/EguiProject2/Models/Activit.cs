using System;
using System.ComponentModel.DataAnnotations;

namespace EguiProject2.Models
{
    public class Activit{
        // Activity model (Called Activit to avoid colission with Activity)
        public int slot{ get; set; }
        public int day{ get; set; }
        public string teacher{ get; set; }
        public string group{ get; set; }
        public string room{ get; set; }
        public string @class{ get; set; }
        
        public Activit(string room, int day, int slot, string group, string teacher, string @class){
            this.room = room;
            this.day = day;
            this.slot = slot;
            this.group = group;
            this.teacher = teacher;
            this.@class = @class;
        }
    }
}
