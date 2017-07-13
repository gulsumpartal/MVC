using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ActionTürleri.Controllers
{
    public class Home3Controller : Controller
    {
        #region RedirectToRouteResult

        private static List<string> dataList = new List<string>();
        // GET: Home3
        public ActionResult Sayfamiz()
        {
            ViewBag.Data = dataList;

            return View();
        }
        [HttpPost]
        public ActionResult Sayfamiz(string ad, string soyad)
        {
            dataList.Add(ad + " " + soyad);
            return new RedirectToRouteResult(
                new RouteValueDictionary(
                    new
                    {
                        action = "Sayfamiz",
                        controller = "Home3",
                        kod = Guid.NewGuid().ToString()
                    }));
        }

        #endregion

    }
}