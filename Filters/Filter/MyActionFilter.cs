using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Models;

namespace Filters.Filter
{
    //actionların başına attribute olarak yazabilmek için filterAttribute özelliğinden türetilmelidir. 
    //actionların başlangıç ve bitiş anında çalışabilmesi için IactionFilter classından türetilmelidir:
    public class MyActionFilter :FilterAttribute,IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = "test",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuting"

            });
            db.SaveChanges();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Logs.Add(new Log()
            {
                KullaniciAdi = "test",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuted"

            });
            db.SaveChanges();
        }
    }
}