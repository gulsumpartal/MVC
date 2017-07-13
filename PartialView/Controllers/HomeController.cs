using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            ViewData["text1"] = "test";
            ViewData["check1"] = true;

            ViewBag.text2 = "test 2";

            return View();
        }

    }
}