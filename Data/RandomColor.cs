using System;

namespace OnlineCalendarSystem_Tier1.Data
{
    public class RandomColor
    {
        private static Random _random = new Random();

        private static string[] colors = new[] {"magenta", "yellow", "yellow-green", "pink-red", "red-orange"};

        public static string GetColor()
        {
            return colors[_random.Next(0, colors.Length)];
        }
    }
}