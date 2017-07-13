using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationDataAnnotaion.Models
{
    public class Kullanici
    {
        [DisplayName("Adı : "),
            Required(ErrorMessage = "Adı alanı zorunludur")]
        public string Ad { get; set; }
        [DisplayName("Soyadı :"),Required(ErrorMessage = "Soyadı giriniz")]
        public string Soyad { get; set; }
        [DisplayName("Yaş :"),
            Required(ErrorMessage = "Yaş giriniz"),
            Range(1,100,ErrorMessage = "Yaş değeri {1} ile {2} arasında olmalıdır.")]
        public int Yas { get; set; }
        [DisplayName("Kullanıcı Adı : "),
            Required(ErrorMessage="Kullanıcı Adı giriniz"),
            MaxLength(55,ErrorMessage = "Max karakter sayısı {1} olmalıdır."),
            MinLength(5,ErrorMessage = "Kullanıcı Adı min. {1} karakter olmalıdır.")]
        //0 propery (display) adını temsil eder 1 dataannotaion içine yazılan rakamları 
        public string KullaniciAdi { get; set; }
        [DisplayName("Şifre : "),
            Required(ErrorMessage="Lütfen şifre giriniz."),
            MaxLength(16,ErrorMessage = "Şifre alanı max. 16 karakter olmalıdır."),
            MinLength(6,ErrorMessage = "Şifre alanı min. 5 karakter olmalıdır."),
            DataType(DataType.Password)]
        public string Sifre { get; set; }
        public string Sifre2 { get; set; }
        [DisplayName("Mail Adresi"),
            Required,
            MaxLength(60),
            EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string Mail { get; set; }
        [DisplayName("Mail Adresi(tekrar) : "),
            Required, 
            MaxLength(60),
            EmailAddress,Compare(nameof(Mail))]
        public string Mail2 { get; set; }
        [DisplayName("Spor Takımınız :"),
            MaxLength(25)]
        public string Takiminiz { get; set; }
    }
}