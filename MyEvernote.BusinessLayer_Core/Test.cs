using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEvernote.Common;

namespace MyEvernote.BusinessLayer_Core
{
    public class Test
    {
        Reporsitory<EvernoteUser> userRepo = new Reporsitory<EvernoteUser>();
        public Test()
        {
            Reporsitory<Category> repo = new Reporsitory<Category>();
            var a = repo.List();
        }

        public void InsertUserTest()
        {

            userRepo.Insert(new EvernoteUser()
            {
                Name = "gulsum",
                Surname = "partal",
                Email = "gulsum.partal@mailinator.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "gulsumpartal",
                Password = "12345",
                CrearedUsername = "gulsumpartal",
                CeratedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddDays(1),
                ModifiedUsername = "gulsumpartal"
            });
        }

        public void Update()
        {
            var user = userRepo.Find(p=>p.Username=="gulsumpartal");
            if (user != null)
            {
                user.Name = "Gülsüm";
                user.Surname = "Partal";

                userRepo.Update(user);
            }
        }
      
    }
}
