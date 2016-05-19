using MVCHolidays.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHolidays.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            DateTime dateNow = DateTime.Now;

            //making holidays
            Holiday queensBirthday = new Holiday();
            Holiday halloween = new Holiday();
            Holiday boxingDay = new Holiday();
            //adding holiday information
            queensBirthday.HolidayName = "Queen's Birthday";
            queensBirthday.HolidayDate = new DateTime(dateNow.Year, 6, 6);
            queensBirthday.HolidayImageFileName = "/images/queensBirthday.jpg";
            halloween.HolidayName = "Halloween";
            halloween.HolidayDate = new DateTime(dateNow.Year, 8, 31);
            halloween.HolidayImageFileName = "/images/halloween.jpg";
            boxingDay.HolidayName = "Boxing Day";
            boxingDay.HolidayDate = new DateTime(dateNow.Year, 12, 26);
            boxingDay.HolidayImageFileName = "/images/boxingDay.jpg";

            //adding holidays to a list
            List<Holiday> holidayList = new List<Holiday>();
            holidayList.Add(queensBirthday);
            holidayList.Add(halloween);
            holidayList.Add(boxingDay);

            //getting random holiday
            Random rand = new Random();
            int randHoliday = rand.Next(holidayList.Count);

            //finding out how many days until holiday
            if (holidayList[randHoliday].HolidayDate < dateNow)
                holidayList[randHoliday].HolidayDate = holidayList[randHoliday].HolidayDate.AddYears(1);

            holidayList[randHoliday].daysUntilHoliday = (holidayList[randHoliday].HolidayDate - dateNow).Days;

            return View(holidayList[randHoliday]);
        }
    }
}