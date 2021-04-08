using System;

namespace Holidays
{
    public interface IHolidayPlanner
    {
        public int GetNeededHolidays(DateTime firstDay, DateTime lastDay);
    }
}
