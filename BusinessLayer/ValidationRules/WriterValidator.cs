using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adi soyada kismi bos geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi bos gecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girisi yapan");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girisi yapin");

        }
		
	}
}

