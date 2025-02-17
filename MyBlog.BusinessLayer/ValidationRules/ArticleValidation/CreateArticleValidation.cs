using FluentValidation;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.ArticleValidation;

public class CreateArticleValidation:AbstractValidator<Article>
{
    public CreateArticleValidation()
    {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz.");
    }
    
}