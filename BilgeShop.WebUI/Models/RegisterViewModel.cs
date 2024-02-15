using System.ComponentModel.DataAnnotations;

namespace BilgeShop.WebUI.Models
{
    public class RegisterViewModel
    {

        [Display(Name ="Ad")]
        [MaxLength(25, ErrorMessage ="Ad en fazla 25 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage ="Ad alanı boş bırakılamaz.")]
        public string FirstName { get; set; }

        [Display(Name ="Soyad")]
        [MaxLength(25, ErrorMessage ="Soyad en fazla 25 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage ="Soyad Alanı Boş Bırakılamaz.")]
        public string LastName { get; set; }

        [Display(Name ="Eposta")]
        [Required(ErrorMessage ="Eposta Alanı Boş Bırakılamaz.")]
        public string Email { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Şifre Alanı Boş Bırakılamaz")]
        public string Password { get; set; }

        [Display(Name = "Şifre tekrar")]
        [Required(ErrorMessage = "Şifre Alanı Boş Bırakılamaz")]
        [Compare(nameof(Password), ErrorMessage ="Şifreler Eşleşmiyor!")]
        public string PasswordConfirm { get; set; }
    }
}
