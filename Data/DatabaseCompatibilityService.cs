using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Data
{
    public class DatabaseCompatibilityService
    {
        public static string createVarchar(int maxChar, string text)
        {
            if (text.Length > maxChar)
            {
                return text.Substring(0, maxChar);
            }
            return text;
        }
    }
}
