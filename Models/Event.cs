using OnlineCalendarSystem_Tier1.Data;
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
            this.title = DatabaseCompatibilityService.createVarchar(30, title);
            this.description = DatabaseCompatibilityService.createVarchar(200, description);
            this.location = DatabaseCompatibilityService.createVarchar(30, location);
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
