using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class Event
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public Date startDate { get; set; }
        public Date endDate { get; set; }

        public Event(int id, string title, string description, string location, Date startDate, Date endDate)
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
