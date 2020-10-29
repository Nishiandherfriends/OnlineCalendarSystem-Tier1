using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class Invite
    {
        //Maybe I should take out the userInvitingID and put the userInvitingUsername
        public int userInvitingID { get; set; }
        public int userInvitedID { get; set; }
        public int eventID { get; set; }
        //Maybe add the event name and description

        public Invite()
        {

        }
    }
}
