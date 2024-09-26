using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppUserDTOs
{
    public class AppUserRegisterDtos
    {
        [Required(ErrorMessage = "Ad Kısmı Zorunludur!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyad Kısmı Zorunludur!")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Kullanıcı Ad Kısmı Zorunludur!")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Mail Kısmı Zorunludur!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Kısmı Zorunludur!")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifre Tekrar Kısmı Zorunludur!")]
        [Compare("Password", ErrorMessage = "Şifre Uyumlu Değil.")]
        public string ConfirmPassword { get; set; }
    }
}
