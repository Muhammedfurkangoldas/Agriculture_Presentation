using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel URL Boş geçilemez");
            RuleFor(x => x.PersonName).NotEmpty().MinimumLength(3).WithMessage("İsim en az 3 karakterli olmalıdır");
            RuleFor(x => x.PersonName).NotEmpty().MaximumLength(50).WithMessage("İsim en fazla 50 karakterli olmalıdır");
            RuleFor(x => x.Title).NotEmpty().MinimumLength(3).WithMessage("Başlık en az 3 karakterli olmalıdır");
            RuleFor(x => x.Title).NotEmpty().MaximumLength(50).WithMessage("Başlık en fazla 50 karakterli olmalıdır");

        }
    }
}
