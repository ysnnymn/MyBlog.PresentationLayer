using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class ArticleManager:IArticleService
{
   private readonly IArticleDal _articleDal;

    public ArticleManager(IArticleDal articleDal)
    {
        _articleDal = articleDal;
    }

    public void TInsert(Article entity)
    {
_articleDal.Insert(entity);    }

    public void TUpdate(Article entity)
    {
        _articleDal.Update(entity);
    }

    public void TDelete(int id)
    {
_articleDal.Delete(id);

    }

    public Article TGetById(int id)
    {
 return _articleDal.GetById(id);

    }

    public List<Article> TGetListAll()
    {
        return _articleDal.GetListAll();
        
    }

    public List<Article> TGetArticlesByWriter(int id)
    {
        return _articleDal.GetArticlesByWriter(id);
    }

   public List<Article> TGetArticlesWithCategoryByWriter(int id)
    {
        return _articleDal.GetArticlesWithCategoryByWriter(id);
    }

    public List<Article> TGetArticlesWithCategory()
    {
        return _articleDal.GetArticlesWithCategory();
    }

    public Article TGetArticleWithCategoryByArticleId(int id)
    {
        return _articleDal.GetArticleWithCategoryByArticleId(id);
    }
}