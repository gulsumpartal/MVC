using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ModelYapisi.Models
{
    [Table("Adresler")]
    public class Adress
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }
        public string AddressDetail { get; set; }
        public Kisi KisiId { get; set; }
    }
}