using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionTürleri.Models;

namespace ActionTürleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //ilgili sayfaya yönlendirme yapılmasını sağlar base classdır diğer ActionTürleri burdan türer
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            //bir url ister sayfalar arası yönlenme sağlar yada bir siteye yönlenme sağlar
            return Redirect("Home/Index");
        }

        public ActionResult Index3()
        {
            return View();
        }
        ////get işlemi şeklinde yazılır ajax içinden get gelirse allowget olmasına izin verilmesi yada direk post göndermektetir.
        //public JsonResult Index4()
        //{
        //    Urun data =new Urun();
        //    data.Id = 5;
        //    data.Aciklama = "Test";
        //    data.Adi = "test urun";
        //    data.Fiyat = 12;
        //    return Json(data,JsonRequestBehavior.AllowGet);
        //}


        public JsonResult Index4()
        {
            Urun data = new Urun();
            data.Id = 5;
            data.Aciklama = "Test";
            data.Adi = "test urun";
            data.Fiyat = 12;
            return Json(data);
        }
    }
}