using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.EntityFramework;

public class EfArticleDal:GenericRepository<Article>,IArticleDal
{
    BlogContext context = new BlogContext();
    public List<Article> GetArticlesByWriter(int id)
    {
        var values=context.Articles.Where(x=>x.AppUserId == id).ToList();
        return values;
    }

 public   List<Article> GetArticlesWithCategoryByWriter(int id)
    {
        var values=context.Articles.Where(x=>x.AppUserId==id).Include(x=>x.Category).ToList();
        return values;
    }

    public List<Article> GetArticlesWithCategory()
    {
       var values=context.Articles.Include(x=>x.Category).ToList();
       return values;
    }

    public Article GetArticleWithCategoryByArticleId(int id)
    {
        var values = context.Articles.Where(x => x.ArticleId == id).Include(y => y.Category).FirstOrDefault();
        return values;
    }
}