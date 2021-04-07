using Holidays.Extensions;
using System;
using Holidays.Interfaces;

namespace Holidays
{
    public class HolidayPeriod : IHolidayPeriod
    {
        public bool FitsInsideHolidayPeriod(DateTime firstDay, DateTime lastDay)
        {
            var firstDayOfPeriod = new DateTime(firstDay.Year, 4, 1);
            var lastDayOfPeriod = new DateTime(firstDay.Year + 1, 3, 31);

            return firstDay.IsDuring(firstDayOfPeriod, lastDayOfPeriod);
        }
    }
}
