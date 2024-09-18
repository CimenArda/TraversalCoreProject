using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Şifre Alanı Zorunludur!")]
        public string Password { get; set; }
    }
}
