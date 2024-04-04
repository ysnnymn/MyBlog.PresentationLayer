using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T:class,IEntity,new()
	{
        void TInsert(T entity);
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetListAll();
        T TGetById(int id);
    }
}

