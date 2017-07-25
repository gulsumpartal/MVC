using System;
using MyEvernote.Common;
using MyEvernote.DataAccessLayer_Infastructure.EntityFramework;

namespace MyEvernote.BusinessLayer_Core
{
    public class Test
    {
        Reporsitory<EvernoteUser> userRepo = new Reporsitory<EvernoteUser>();
        Reporsitory<Comment> commentReporsitory = new Reporsitory<Comment>();
        Reporsitory<Note> noteReporsitory= new Reporsitory<Note>();

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

        public void InsertComment()
        {
            var user = userRepo.Find(p => p.Id == 1);
            Note note = noteReporsitory.Find(p => p.Title == "test");
            

            Comment comment = new Comment()
            {
                Text = "test",
                CrearedUsername = "gulsumpartal",
                CeratedOn = DateTime.Now,
                ModifiedOn= DateTime.Now,
                ModifiedUsername="gulsumpartal",
                Note = note,
                EvernoteUser = user
            };
            commentReporsitory.Insert(comment);

        }
      
    }
}
