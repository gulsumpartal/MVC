using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModelYapisi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Adress> Adresler { get; set; }

        public DatabaseContext() : base("default")
        {

        }
    }
}