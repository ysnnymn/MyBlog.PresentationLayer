using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Context;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.EntityFramework;

public class EfCommentDal:GenericRepository<Comment>,ICommentDal
{
    BlogContext context = new BlogContext();
    public List<Comment> GetCommentsByBlog(int id)
    {
       var values=context.Comments.Where(x=>x.ArticleId==id).ToList();
       return values;
    }
}