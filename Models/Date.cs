using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Models
{
    /// <summary>
    /// This class holds values for year, month, day, hour, minute and second.
    /// This is used to increase compatibility with the Java part of the program.
    /// </summary>
    public class Date
    {
        [NotNull, Range(1970, 2170)]
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
        
        public Date() {}

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
