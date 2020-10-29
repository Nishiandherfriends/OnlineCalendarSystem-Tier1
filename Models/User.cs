using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public int securityLevel { get; set; }

        public User(int id, string username, int securityLevel)
        {
            this.id = id;
            this.username = username;
            this.securityLevel = securityLevel;
        }

    }
}
