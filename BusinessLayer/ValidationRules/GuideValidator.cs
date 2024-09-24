using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<EntityLayer.Concrete.Guid>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı Boş Geçilemez");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Açıklama Kısmı Minimum 10 Karakter Olmalıdır");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Kısmı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Ad Kısmı Minimum 5 Karakter  Olmalıdır.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Kısmı Boş Geçilemez");
 
        }
    }
}
