using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filters.Models
{
    [Table("SiteUsers")]
    public class SiteUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(20), DisplayName("Adınız ")]
        public string Ad { get; set; }
        [Required,StringLength(20),DisplayName("Soyadınız ")]
        public string Soyad { get; set; }
        [Required, StringLength(20), DisplayName("Kullanıcı Adı9 ")]
        public string KullaniciAdi { get; set; }
        [Required,StringLength(16),DisplayName("Şifre"),DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}