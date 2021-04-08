using System;

namespace Holidays.NationalHolidays
{
    public interface INationalHolidays
    {
        public bool IsNationalHoliday(DateTime date);
    }
}
