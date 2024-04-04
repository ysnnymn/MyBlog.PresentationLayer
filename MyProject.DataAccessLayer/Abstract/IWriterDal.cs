using MyBlog.EntitiyLayer.Concrete;


namespace MyProject.DataAccessLayer.Abstract
{
    public interface IWriterDal : IGenericDal<Writer>
    {
        int GetWriterCount();
    }
}

