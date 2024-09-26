using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator :AbstractValidator<AppUserRegisterDtos>
    {
        public AppUserRegisterValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Kısmı Boş Geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Kısmı Boş Geçilemez!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Kısmı Boş Geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Kısmı Boş Geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Kısmı Boş Geçilemez!");


            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ad Kısmı En Az 3 Karakter Olmalıdır!");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Soyad Kısmı En Az 3 Karakter Olmalıdır!");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Kullanıcı Adı Kısmı En Az 5 Karakter Olmalıdır!");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail Formatınız Yanlış!");

        }
    }
}
