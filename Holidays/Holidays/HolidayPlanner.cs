using Holidays.Extensions;
using Holidays.Interfaces;
using Holidays.NationalHolidays;
using System;

namespace Holidays
{
    public class HolidayPlanner : IHolidayPlanner
    {
        private NationalHolidaysBase _nationalHolidays;
        private IDateSpanValidator _spanValidator;

        public HolidayPlanner(IDateSpanValidator spanValidator, NationalHolidaysBase nationalHolidays)
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

            for (int i = 0; i < days; i++)
            {
                var iteratedDay = firstDay.AddDays(i);

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
