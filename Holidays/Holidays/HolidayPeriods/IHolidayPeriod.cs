using System;

namespace Holidays.HolidayPeriods
{
    public interface IHolidayPeriod
    {
        public bool FitsInsideHolidayPeriod(DateTime firstDay, DateTime lastDay);
    }
}
