using System;

namespace Holidays.NationalHolidays
{
    public record Holiday
    {
        private byte _day;
        private byte _month;
        private int _year;

        public int Day => _day;
        public int Month => _month;
        public int Year => _year;

        public Holiday(int day, int month, int year)
        {
            _day = Convert.ToByte(day);
            _month = Convert.ToByte(month);
            _year = year;
        }
    }
}
