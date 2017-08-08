using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyEvernote.BusinessLayer_Core;

namespace MyEvernote.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NoteService noteService = new NoteService();
            var model = noteService.GetNoteswithOrderByDesc();
            return View(model);
        }

        public ActionResult ByCategory(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryService categoryService = new CategoryService();
            var data = categoryService.GetCategoryById(id);
            if (data==null)
            {
                return HttpNotFound();
            }

            var model = data.Notes.OrderByDescending(p => p.ModifiedOn).ToList();

            return View("Index", model);
        }
    }
}