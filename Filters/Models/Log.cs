using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,DisplayName("İşlem Tarihi")]
        public DateTime Tarih { get; set; }
        [Required,DisplayName("Kullanıcı Adı"),StringLength(25)]
        public string KullaniciAdi { get; set; }
        [Required, DisplayName("Action"), StringLength(100)]
        public string ActionName { get; set; }
        [Required, DisplayName("Controller"), StringLength(100)]
        public string ControllerName { get; set; }
        [DisplayName("Bilgi"), StringLength(100)]
        public string Bilgi { get; set; }
    }
}