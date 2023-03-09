using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class BlogValidator: AbstractValidator<Blog>
	{
		public BlogValidator()
		{
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog basligina bo§ geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içerigini bos gecemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini bos geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girisi yapin");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4 karakterden daha fazla veri girisi yapin");
        }
	}
}

