using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult About()
        {
            ViewBag.Message = "MovieHub: Your Ultimate Cinema Companion";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more details contact :";

            return View();
        }
    }
}