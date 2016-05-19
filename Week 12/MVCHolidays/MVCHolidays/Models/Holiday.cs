using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHolidays.Models
{
    public class Holiday
    {
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayImageFileName { get; set; }
        public int daysUntilHoliday { get; set; }
    }
}