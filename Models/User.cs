using OnlineCalendarSystem_Tier1.Data;
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
        public string password { get; set; }
        public int securityLevel { get; set; }

        public User(int id, string username, string password, int securityLevel)
        {
            this.id = id;
            this.username = DatabaseCompatibilityService.createVarchar(15, username);
            this.password = DatabaseCompatibilityService.createVarchar(15, password);
            this.securityLevel = securityLevel;
        }

    }
}
