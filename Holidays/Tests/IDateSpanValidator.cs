using Holidays.HolidaySpanValidators;
using NUnit.Framework;
using System;

namespace Tests
{
    public class HolidaySpanValidatorTests
    {
        IHolidaySpanValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new HolidaySpanValidator();
        }

        [Test(ExpectedResult = true)]
        public bool ValidDaySpan()
        {
            var firstDay = new DateTime(2021, 12, 1);
            var lastDay = new DateTime(2022, 1, 2);

            return _validator.ValidateDateSpan(firstDay, lastDay, out string msg);
        }

        [Test(ExpectedResult = false)]
        public bool InvalidDaySpan()
        {
            var firstDay = new DateTime(2021, 3, 1);
            var lastDay = new DateTime(2022, 4, 1);

            return _validator.ValidateDateSpan(firstDay, lastDay, out string msg);
        }

    }
}
