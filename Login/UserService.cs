using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Models;

namespace OnlineCalendarSystem_Tier1.Login
{
    public sealed class UserService
    {
        private static User user = null;

        public static User GetUser() => user;

        public static void SetUser(User input) => user = input;
    }
}