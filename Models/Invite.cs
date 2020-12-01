using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    /// <summary>
    /// This class hold the Invite information such as the username of the user that is inviting, the id of the user invited,
    /// the id of the event, the starting date and the end date.
    /// </summary>
    public class Invite
    {
        public string userInvitingUsername { get; set; }
        public int userInvitedID { get; set; }
        public int eventID { get; set; }
        public Date startingDate { get; set; }
        public Date endDate { get; set; }

        public Invite() {}

        public Invite(string userInvitingUsername, int userInvitedID, int eventID, Date startingDate, Date endDate)
        {
            this.userInvitingUsername = userInvitingUsername;
            this.userInvitedID = userInvitedID;
            this.eventID = eventID;
            this.startingDate = startingDate;
            this.endDate = endDate;
        }
    }
}
