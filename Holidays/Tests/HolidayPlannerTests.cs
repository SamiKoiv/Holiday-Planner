using Holidays;
using Holidays.HolidaySpanValidators;
using Holidays.NationalHolidays;
using NUnit.Framework;
using System;

namespace Tests
{
    public class HolidayPlannerTests
    {
        IHolidayPlanner _planner;
        INationalHolidays _testHolidays;
        IHolidaySpanValidator _spanValidator;

        [SetUp]
        public void Setup()
        {
            _spanValidator = new HolidaySpanValidator();
            _testHolidays = new FinnishHolidaysTest();
            _planner = new HolidayPlanner(_spanValidator, _testHolidays);
        }

        [Test]
        public void InvalidSpan()
        {
            // Last before first
            var firstDay = new DateTime(2021, 5, 1);
            var lastDay = firstDay.AddDays(-7);

            Assert.Throws<ArgumentException>(() => _planner.GetNeededHolidays(firstDay, lastDay));

            // Over 50 days
            firstDay = new DateTime(2021, 4, 1);
            lastDay = firstDay.AddDays(70);

            Assert.Throws<ArgumentException>(() => _planner.GetNeededHolidays(firstDay, lastDay));


            // Outside holiday period
            firstDay = new DateTime(2021, 3, 1);
            lastDay = new DateTime(2021, 4, 1);

            Assert.Throws<ArgumentException>(() => _planner.GetNeededHolidays(firstDay, lastDay));
        }

        [Test(ExpectedResult = 25)]
        public int GetHolidaysOnDecember()
        {
            var firstDay = new DateTime(2021, 12, 1);
            var lastDay = new DateTime(2021, 12, 31);

            return _planner.GetNeededHolidays(firstDay, lastDay);
        }

        [Test(ExpectedResult = 24)]
        public int GetHolidaysOnApril()
        {
            var firstDay = new DateTime(2021, 4, 1);
            var lastDay = new DateTime(2021, 4, 30);

            return _planner.GetNeededHolidays(firstDay, lastDay);
        }

        [Test(ExpectedResult = 2)]
        public int GetHolidaysOnFirstWeekOfApril()
        {
            var firstDay = new DateTime(2021, 4, 1);
            var lastDay = new DateTime(2021, 4, 4);

            return _planner.GetNeededHolidays(firstDay, lastDay);
        }

        [Test(ExpectedResult = 5)]
        public int GetHolidaysOnSecondWeekOfApril()
        {
            var firstDay = new DateTime(2021, 4, 5);
            var lastDay = new DateTime(2021, 4, 11);

            return _planner.GetNeededHolidays(firstDay, lastDay);
        }

        [Test(ExpectedResult = 6)]
        public int GetHolidaysOnThirdWeekOfApril()
        {
            var firstDay = new DateTime(2021, 4, 12);
            var lastDay = new DateTime(2021, 4, 18);

            return _planner.GetNeededHolidays(firstDay, lastDay);
        }

    }
}