using System;

namespace Holidays.Interfaces
{
    public interface IDateSpanValidator
    {
        public bool ValidateDateSpan(DateTime firstDay, DateTime lastDay, out string validationMessage);
    }
}
