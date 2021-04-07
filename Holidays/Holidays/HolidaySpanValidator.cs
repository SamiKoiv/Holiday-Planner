﻿using Holidays.Extensions;
using Holidays.Interfaces;
using System;

namespace Holidays
{
    public class HolidaySpanValidator : IDateSpanValidator
    {
        IHolidayPeriod _holidayPeriod = new HolidayPeriod();

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
