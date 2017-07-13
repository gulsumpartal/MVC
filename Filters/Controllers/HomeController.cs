using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Filter;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MyActionFilter]
        public ActionResult Index()
        {
            return View();
        }
        [MyActionFilter]
        public ActionResult Index2()
        {
            return View();
        }
        [MyActionFilter]
        public ActionResult Index3()
        {
            return View();
        }
    }
}