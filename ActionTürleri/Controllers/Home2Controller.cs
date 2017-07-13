using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionTürleri.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public FileResult ShowPdf()
        {
            string filePath = Server.MapPath("~/Files/images.pdf");

            return new  FilePathResult(filePath,"application/pdf");
        }
     
    }
}