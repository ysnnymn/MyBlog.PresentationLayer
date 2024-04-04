using System;
using FluentValidation;
using MyBlog.EntitiyLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.CategoryValidation
{
	public class CreateCategoryValidation:AbstractValidator<Category>
	{
		public CreateCategoryValidation()
		{
			RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
			RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız.");
			RuleFor(c => c.CategoryName).Must(c => c.Length < 38).WithMessage("Kategori Adı 38 karakterden fazla olamaz");
		}
	}
}

