using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Login
{
    public class User
    {
        public int id { get; set; }
        [NotNull]
        public string username { get; set; }
        [NotNull]
        public string password { get; set; }
        [NotNull, Range(1,3)]
        public int securityLevel { get; set; }

        public User(int id, string username, string password, int securityLevel)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.securityLevel = securityLevel;
        }

    }
}
