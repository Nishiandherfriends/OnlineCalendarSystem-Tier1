using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    /// <summary>
    /// This class hold the Invite information such as the username of the user that is inviting, the id of the user invited and the event to which the user is invited.
    /// </summary>
    public class Invite
    {
        public string userInvitingUsername { get; set; }
        public int userInvitedID { get; set; }
        public Event evt { get; set; }

        public Invite() {}

        public Invite(string userInvitingUsername, int userInvitedID, Event evt)
        {
            this.userInvitingUsername = userInvitingUsername;
            this.userInvitedID = userInvitedID;
            this.evt = evt;
        }
    }
}
