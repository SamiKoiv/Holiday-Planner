using System;

namespace Holidays.Extensions
{
    public static class DateTimeExtensions
    {

        public static bool IsDuring(this DateTime day, DateTime firstDay, DateTime lastDay) => day.CompareTo(firstDay) >= 0 && day.CompareTo(lastDay) <= 0;
        public static int GetDaysUntil(this DateTime day, DateTime lastDay) => (int)Math.Ceiling(lastDay.Subtract(day).TotalDays);
        public static bool IsSunday(this DateTime day) => day.DayOfWeek == DayOfWeek.Sunday;

    }
}
