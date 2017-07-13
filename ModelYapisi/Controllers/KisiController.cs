using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelYapisi.Models;

namespace ModelYapisi.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        public ActionResult Yeni()
        {
            //kullanıcı dan dataları almak için yeni bir form açılmalı
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Kisi kisi)
        {
            DatabaseContext db = new DatabaseContext();
            db.Kisiler.Add(kisi);
            var sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                ViewBag.Result = "Kişi eklendi.";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Result = "Hata";
                ViewBag.Status = "danger";
            }

            return View();
        }

        public ActionResult Duzenle(int? id)
        {
            Kisi kisi = null;
            if (id != null)
            {
                DatabaseContext db = new DatabaseContext();
                kisi = db.Kisiler.FirstOrDefault(p => p.Id == id);
            }

            return View(kisi);
        }
        [HttpPost]
        public ActionResult Duzenle(Kisi model,int? id)
        {

            DatabaseContext db = new DatabaseContext();
            var dbEntity = db.Kisiler.FirstOrDefault(p => p.Id == id);
            if (dbEntity!=null)
            {
                dbEntity.Ad = model.Ad;
                dbEntity.Soyad = model.Soyad;
                dbEntity.Yas = model.Yas;

                var sonuc =db.SaveChanges();

                if (sonuc > 0)
                {
                    ViewBag.Result = "başarılı";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Hata";
                    ViewBag.Status = "danger";
                }
            }

            return View();
        }

        public ActionResult Sil(int? id)
        {
            Kisi kisi = null;
            if (id != null)
            {
                DatabaseContext db = new DatabaseContext();
                kisi = db.Kisiler.FirstOrDefault(p => p.Id == id);
            }

            return View(kisi);
        }

        [HttpPost,ActionName("Sil")]
        public ActionResult SilPost(int? id)
        {
            if (id != null)
            {
                DatabaseContext db = new DatabaseContext();
               var  kisi = db.Kisiler.FirstOrDefault(p => p.Id == id);
                db.Kisiler.Remove(kisi);
                db.SaveChanges();
            }

            return RedirectToAction("HomePage","Home");
        }
    }
}