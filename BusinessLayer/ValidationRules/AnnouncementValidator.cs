using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator :AbstractValidator<AnnouncementAddDto>
    {

        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Lütfen En az 10 karakter veri girişi yapınız.");


            RuleFor(x=>x.Content).NotEmpty().WithMessage("İçerik Alanı Boş Geçilemez");
            RuleFor(x => x.Content).MinimumLength(50).WithMessage("Lütfen En az 50 karakter veri girişi yapınız.");

        }
    }
}
