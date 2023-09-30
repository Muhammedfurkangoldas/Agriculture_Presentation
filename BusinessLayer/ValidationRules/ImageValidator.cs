using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklaması boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolunu Boş Geçemezsiniz!");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Başlık En fazla 30 karakter içermelidir!");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Başlık en az 8 karakter içermelidir!");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("Açıklama en fazla 100 karakter içermelidir!");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Açıklama en az 20 karakter içermelidir!");
        }
    }
}
