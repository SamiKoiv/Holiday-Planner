using System;
using System.Collections.Generic;
using System.Linq;

namespace Holidays.NationalHolidays
{
    public abstract class NationalHolidaysBase
    {
        protected List<DateTime> _holidays;

        public NationalHolidaysBase()
        {

        }

        public bool IsNationalHoliday(DateTime date)
        {
            return _holidays.Any(holiday => holiday.CompareTo(date) == 0);
        }

    }
}
