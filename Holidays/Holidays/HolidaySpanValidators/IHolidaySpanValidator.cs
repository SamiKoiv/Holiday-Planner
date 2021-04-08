using System;

namespace Holidays.HolidaySpanValidators
{
    public interface IHolidaySpanValidator
    {
        public bool ValidateDateSpan(DateTime firstDay, DateTime lastDay, out string validationMessage);
    }
}
