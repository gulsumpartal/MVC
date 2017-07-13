using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionTürleri.Controllers
{
    public class Home4Controller : Controller
    {
        // GET: Home4
        public ActionResult Anasayfa()
        {
            return View();
        }

        public PartialViewResult KategorilerPartialGetir()
        {
            return PartialView("_kategoriPartial");
        }

        public PartialViewResult Kategoriler2PartialGetir()
        {
            List<string> kategoriler = new List<string>()
            {

                "test1",
                "test2",
                "test3",
                "test1",
                "test2",
                "test3",
                "test4"
            };
            return PartialView("_Kategoriler2Partial", kategoriler);
        }
    }
}