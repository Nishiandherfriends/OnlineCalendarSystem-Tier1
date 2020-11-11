using System.Collections.Generic;

namespace OnlineCalendarSystem_Tier1.Models{
    public class Week
    {
        public List<Event> Dates{get;set;} = new List<Event>();
    }
}