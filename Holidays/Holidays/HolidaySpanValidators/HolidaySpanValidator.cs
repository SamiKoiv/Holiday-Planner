using Holidays.Extensions;
using Holidays.HolidayPeriods;
using System;

namespace Holidays.HolidaySpanValidators
{
    public class HolidaySpanValidator : IHolidaySpanValidator
    {
        IHolidayPeriod _holidayPeriod = new FinnishHolidayPeriod();

        public bool ValidateDateSpan(DateTime firstDay, DateTime lastDay, out string validationMessage)
        {
            var days = firstDay.GetDaysUntil(lastDay);

            if (days < 0)
            {
                validationMessage = "Last day is before the first day.";
                return false;
            }

            if (days > 50)
            {
                validationMessage = "Invalid date span.";
                return false;
            }

            if (!_holidayPeriod.FitsInsideHolidayPeriod(firstDay, lastDay))
            {
                validationMessage = "Determined range spans over holiday period.";
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

    }
}
