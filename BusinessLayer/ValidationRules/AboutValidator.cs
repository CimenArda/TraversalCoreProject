﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator :AbstractValidator<About>
    {

        public AboutValidator() 
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x=>x.Description).MinimumLength(50).WithMessage("En az 50 karakterlik açıklama bilgisi girilmelidir.");
            RuleFor(x=>x.Description).MaximumLength(50).WithMessage("En fazla 200 karakterlik açıklama bilgisi girilmelidir.");
            RuleFor(x=>x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz.");
        }
    }
}
