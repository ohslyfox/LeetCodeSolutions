using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem1344
    {
        public static double AngleClock(int hour, int minutes)
        {
            var h = GetHourAngle(hour, minutes);
            var m = GetMinuteAngle(minutes);
            var angle = Math.Abs(h - m);
            return angle > 180 ? 360 - angle : angle;
        }

        public static double GetHourAngle(int hour, int minutes)
        {
            return (hour % 12 * 30) + ((double)minutes / 60 * 30);
        }

        public static double GetMinuteAngle(int minute)
        {
            return minute * 6;
        }
    }
}
