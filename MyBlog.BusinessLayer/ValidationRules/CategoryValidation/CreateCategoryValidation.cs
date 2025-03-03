using FluentValidation;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.CategoryValidation;

public class CreateCategoryValidation:AbstractValidator<Category>
{
    public CreateCategoryValidation()
    {
        RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
        RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
        RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
    }
}