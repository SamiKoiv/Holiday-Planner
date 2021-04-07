using System;

namespace Holidays.Interfaces
{
    public interface IHolidayPlanner
    {
        public int GetNeededHolidays(DateTime firstDay, DateTime lastDay);
    }
}
