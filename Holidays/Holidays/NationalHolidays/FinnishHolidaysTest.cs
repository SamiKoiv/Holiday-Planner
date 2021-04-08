using System;
using System.Linq;
using System.Collections.Generic;

namespace Holidays.NationalHolidays
{
    public class FinnishHolidaysTest : INationalHolidays
    {
        private List<DateTime> _holidays;

        List<DateTime> testData = new List<DateTime>()
        {
            new DateTime(2021, 1, 1),
            new DateTime(2021, 1, 6),
            new DateTime(2021, 4, 2),
            new DateTime(2021, 4, 5),
            new DateTime(2021, 5, 13),
            new DateTime(2021, 6, 25),
            new DateTime(2021, 12, 6),
            new DateTime(2021, 12, 24),

            new DateTime(2022, 1, 1),
            new DateTime(2022, 1, 6),
            new DateTime(2022, 4, 15),
            new DateTime(2022, 4, 18),
            new DateTime(2022, 5, 1),
            new DateTime(2022, 5, 26),
            new DateTime(2022, 6, 5),
            new DateTime(2022, 6, 24),
            new DateTime(2022, 6, 25),
            new DateTime(2022, 12, 6),
            new DateTime(2022, 12, 24),
            new DateTime(2022, 12, 25),
            new DateTime(2022, 12, 26)
        };

        public FinnishHolidaysTest() : base()
        {
            _holidays = testData;
        }

        public bool IsNationalHoliday(DateTime date)
        {
            return _holidays.Any(holiday => holiday.CompareTo(date) == 0);
        }

    }
}
