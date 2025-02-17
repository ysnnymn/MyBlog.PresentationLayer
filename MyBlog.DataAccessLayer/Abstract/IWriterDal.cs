using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Abstract;

public interface IWriterDal:IGenericDal<Writer>
{
   int GetWriterCount();
}