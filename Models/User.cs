using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class users
    {
        public int id { get; set; }
        [NotNull]
        public string username { get; set; }
        [NotNull]
        public string password { get; set; }
        [NotNull, Range(1,3)]
        public string securityLevel { get; set; }

<<<<<<< HEAD:Login/users.cs
        public users(int id, string username, string password, string securityLevel)
=======
        public User() {}

        public User(int id, string username, string password, string securityLevel)
>>>>>>> b1c23c6c798f15d2297a689444bdafca2321ed62:Models/User.cs
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.securityLevel = securityLevel;
        }
    }
}
