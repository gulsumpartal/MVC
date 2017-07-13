using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ModelYapisi.Models
{
    [Table("Kisiler")]
    public class Kisi
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(25),Required]
        public string Ad { get; set; }
        [StringLength(25), Required]
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public List<Adress> Adresses { get; set; }

    }
}