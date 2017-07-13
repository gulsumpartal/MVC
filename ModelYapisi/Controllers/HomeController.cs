using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelYapisi.DTO.Home;
using ModelYapisi.Models;

namespace ModelYapisi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "gülsüm";
            kisi.Soyad = "partal";
            kisi.Yas = 25;
            //modeli view içersine gönderirken model nesnesini atayabiliriz
            return View(kisi);
        }

        [HttpPost]
        public ActionResult Index(Kisi kisi)
        {
            return View(kisi);
        }

        public ActionResult HomePage()
        {
            DatabaseContext db = new DatabaseContext();
            //db.Kisiler.ToList();
            //db.Adresler

            HomePageDTO data = new HomePageDTO();
            data.Kisiler = db.Kisiler.ToList();
            data.Adresler = db.Adresler.ToList();

            return View(data);
        }
    }
}