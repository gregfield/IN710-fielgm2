using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class DogSelectController : Controller
    {
        // GET: DogSelect
        public ActionResult ShowSelect()
        {
            return View();
        }
    }
}