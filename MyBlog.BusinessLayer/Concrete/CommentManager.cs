using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class CommentManager:ICommentService

{
   private readonly ICommentDal _commentDal;

   public CommentManager(ICommentDal commentDal)
   {
       _commentDal = commentDal;
   }

   public void TInsert(Comment entity)
    {
        _commentDal.Insert(entity);
        
    }

    public void TUpdate(Comment entity)
    {
_commentDal.Update(entity);    }

    public void TDelete(int id)
    {
_commentDal.Delete(id);    }

    public Comment TGetById(int id)
    {
return   _commentDal.GetById(id);

    }

    public List<Comment> TGetListAll()
    {
return    _commentDal.GetListAll();

    }
}