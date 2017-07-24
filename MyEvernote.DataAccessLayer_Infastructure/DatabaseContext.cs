using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEvernote.Common;

namespace MyEvernote.DataAccessLayer_Infastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("default")
        {
            
        }
        public DbSet<EvernoteUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Liked> Likes { get; set; }
    }
}
