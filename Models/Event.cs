using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class Event
    {
        public int id { get; set; }
        [NotNull]
        public string title { get; set; }
        public string description { get; set; }
        public string value { get; set; }
        public string location { get; set; }
        public string dayName{get;set;}
        [NotNull]
        public DateTime startDate { get; set; } = new DateTime(2020,1,1);
        [NotNull]
        public DateTime endDate { get; set; }= new DateTime(2020,1,1);
        public Event(){

        }

        public Event(int id, string title, string description, string location, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
