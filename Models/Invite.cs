using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class Invite
    {
        public int userInvitingID { get; set; }
        public string userInvitingName { get; set; }
        public int userInvitedID { get; set; }
        public int eventID { get; set; }
        public Event evt { get; set; }
        public MyDate startingDate { get; set; }
        public MyDate endDate { get; set; }

        public Invite()
        {

        }
    }
}
