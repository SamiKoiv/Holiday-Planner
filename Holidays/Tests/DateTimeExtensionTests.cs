using Holidays.Extensions;
using NUnit.Framework;
using System;

namespace Tests
{
    public class DateTimeExtensionTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test(ExpectedResult = 1)]
        public int GetDaysUntilSameDay()
        {
            var today = DateTime.Now;
            var other = DateTime.Now;

            var days = today.GetDaysUntil(other);

            return days;
        }

        [Test(ExpectedResult = 3)]
        public int GetDaysUntilThreeDays()
        {
            var today = DateTime.Now;
            var other = today.AddDays(3);

            var days = today.GetDaysUntil(other);

            return days;
        }

        [Test(ExpectedResult = true)]
        public bool IsSunday()
        {
            var day = new DateTime(2021, 4, 18);
            return day.IsSunday();
        }

        [Test(ExpectedResult = false)]
        public bool IsNotSunday()
        {
            var day = new DateTime(2021, 4, 19);
            return day.IsSunday();
        }

        [Test(ExpectedResult = true)]
        public bool IsDuring()
        {
            var today = DateTime.Now;
            var before = today.AddDays(-7);
            var after = today.AddDays(7);

            return today.IsDuring(before, after);
        }

        [Test(ExpectedResult = false)]
        public bool IsNotDuring()
        {
            var today = DateTime.Now;
            var before = today.AddDays(7);
            var after = today.AddDays(14);

            return today.IsDuring(before, after);
        }

    }
}
