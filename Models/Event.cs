using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Data;

namespace OnlineCalendarSystem_Tier1.Models
{
    /// <summary>
    /// This class holds the event informations such as id, title, description, location, start date and end date.
    /// </summary>
    [Serializable]
    public class Event
    {
        public int id { get; set; }
        [NotNull]
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        [NotNull]
        public Date startDate { get; set; }
        [NotNull] 
        public Date endDate { get; set; }
        //public string Color {get; private set;}

        /*public Event()
        {
            Color = RandomColor.GetColor();
        }*/

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
