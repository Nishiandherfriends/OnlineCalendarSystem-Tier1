using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    public class Date
    {
        [NotNull, Range(2020, 2120)]
        public int year { get; set; }
        [NotNull, Range(1,12)]
        public int month { get; set; }
        [NotNull, Range(1,31)]
        public int day { get; set; }
        [NotNull, Range(0,23)]
        public int hour { get; set; }
        [NotNull, Range(0,59)]
        public int minute { get; set; }
        [NotNull, Range(0, 59)]
        public int second { get; set; }

        public Date(int year, int month, int day, int hour, int minute, int second) 
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
