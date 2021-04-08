using Holidays.Extensions;
using Holidays.NationalHolidays;
using Holidays.HolidaySpanValidators;
using System;

namespace Holidays
{
    public class HolidayPlanner : IHolidayPlanner
    {
        private INationalHolidays _nationalHolidays;
        private IHolidaySpanValidator _spanValidator;

        public HolidayPlanner(IHolidaySpanValidator spanValidator, INationalHolidays nationalHolidays)
        {
            _spanValidator = spanValidator;
            _nationalHolidays = nationalHolidays;
        }

        public int GetNeededHolidays(DateTime firstDay, DateTime lastDay)
        {
            var afterLastDay = lastDay.AddDays(1);
            var days = firstDay.GetDaysUntil(afterLastDay);

            if (ValidateDateSpan(firstDay, lastDay, out string validationMessage))
            {
                return CountNeededHolidays(firstDay, days);
            }
            else
            {
                throw new ArgumentException(validationMessage);
            }
        }

        private int CountNeededHolidays(DateTime firstDay, int days)
        {
            int neededHolidays = 0;
            DateTime iteratedDay;

            for (int i = 0; i < days; i++)
            {
                iteratedDay = firstDay.AddDays(i);

                if (NeedsHoliday(iteratedDay))
                {
                    neededHolidays++;
                    Console.WriteLine(iteratedDay);
                }
            }

            return neededHolidays;
        }

        private bool NeedsHoliday(DateTime day)
        {
            if (IsNationalHoliday(day)) return false;
            if (day.IsSunday()) return false;

            return true;
        }

        private bool ValidateDateSpan(DateTime firstDay, DateTime lastDay, out string validationMessage)
        {
            return _spanValidator.ValidateDateSpan(firstDay, lastDay, out validationMessage);
        }

        private bool IsNationalHoliday(DateTime day) => _nationalHolidays.IsNationalHoliday(day);

    }
}
