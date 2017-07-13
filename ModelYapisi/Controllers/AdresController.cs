using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelYapisi.Models;

namespace ModelYapisi.Controllers
{
    public class AdresController : Controller
    {
        // GET: Adres
        public ActionResult Yeni()
        {
            DatabaseContext db = new DatabaseContext();

            List<SelectListItem> kisilerList = (from kisi in db.Kisiler.ToList()
                select new SelectListItem()
                {
                    Text = kisi.Ad + " " + kisi.Soyad,
                    Value = kisi.Id.ToString()
                }).ToList();

            TempData["KisiList"]  = kisilerList;
            ViewBag.KisiList = TempData["KisiList"];
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Adress adres)
        {
            DatabaseContext db = new DatabaseContext();

            Kisi kisi = db.Kisiler.FirstOrDefault(p => p.Id == adres.KisiId.Id);
            if (kisi!=null)
            {
                adres.KisiId = kisi;
                db.Adresler.Add(adres);
                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    ViewBag.Result = "İşlem Başarılı.";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Hata";
                    ViewBag.Status = "danger";
                }

            }
            ViewBag.KisiList = TempData["KisiList"];
            return View();
        }

        public ActionResult Duzenle(int? id)
        {
            DatabaseContext db = new DatabaseContext();
            List<SelectListItem> kisilerList = (from kisi in db.Kisiler.ToList()
                                                select new SelectListItem()
                                                {
                                                    Text = kisi.Ad + " " + kisi.Soyad,
                                                    Value = kisi.Id.ToString()
                                                }).ToList();

            TempData["KisiList"] = kisilerList;
            ViewBag.KisiList = TempData["KisiList"];
            Adress adres = null;
            if (id!=null)
            {
                
                adres = db.Adresler.FirstOrDefault(p => p.Id == id);
            }
            return View(adres);
        }
        [HttpPost]
        public ActionResult Duzenle(Adress model, int? id)
        {
            DatabaseContext db = new DatabaseContext();
            Kisi kisi = db.Kisiler.FirstOrDefault(p => p.Id == model.KisiId.Id);
            Adress dbAdress = db.Adresler.FirstOrDefault(p => p.Id == id);
           
            if (kisi!=null)
            {
                dbAdress.KisiId = kisi;
                dbAdress.AddressDetail = model.AddressDetail;

                db.SaveChanges();
            }
            
            ViewBag.KisiList = TempData["KisiList"];

            return View();
        }
    }
}