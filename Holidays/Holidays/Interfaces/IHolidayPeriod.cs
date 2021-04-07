using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidays.Interfaces
{
    public interface IHolidayPeriod
    {
        public bool FitsInsideHolidayPeriod(DateTime firstDay, DateTime lastDay);
    }
}
