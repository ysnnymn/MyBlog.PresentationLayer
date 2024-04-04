using System;
using FluentValidation;
using MyBlog.EntitiyLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.ArticleValidation
{
	public class CreateArticleValidation:AbstractValidator<Article>
	{
		public CreateArticleValidation()
		{
			RuleFor(a => a.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz.").MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz").MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter giriniz");

			RuleFor(a => a.Detail).NotEmpty().WithMessage("Lütfen boş geçmeyiniz");
		}
	}
}

