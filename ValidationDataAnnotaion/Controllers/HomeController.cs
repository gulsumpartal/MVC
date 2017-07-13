using System.Web.Mvc;
using ValidationDataAnnotaion.Models;

namespace ValidationDataAnnotaion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }
        [HttpPost]
        public ActionResult Index(Kullanici model)
        {
            if (ModelState.IsValid)
            {
                if (model.KullaniciAdi.StartsWith("test"))
                {
                    //test ile başlayan bir isimde hata mesajı eklemek istersek
                    ModelState.AddModelError("KullaniciAdi", "test ile başlamamalıdır.");
                    //hicbir uygun property olmadıgı için validation summary içinde gösterir ancak göstermek için key vermemmek gerekir eger hata var götermemek isteniyorsa herhangi bir key verilir

                    ModelState.AddModelError("", "test ile başlamamalıdır.");
                }

                //hataların clientside olmasını istersek unobtrusive validation bunu sağlar nuget managerden projeye eklenmelid.
            }

            return View();
        }
    }
}