using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Abstract;

public interface IArticleService:IGenericService<Article>
{
    public List<Article> TGetArticlesByWriter(int id);
    public List<Article> TGetArticlesWithCategoryByWriter(int id);
}