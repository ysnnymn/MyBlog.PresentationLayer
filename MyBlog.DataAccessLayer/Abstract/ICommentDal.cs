using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Abstract;

public interface ICommentDal:IGenericDal<Comment>
{
    List<Comment> GetCommentsByBlog(int id);
}