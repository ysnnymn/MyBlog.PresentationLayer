using System;
using System.Linq.Expressions;
using MyBlog.EntitiyLayer.Abstract;

namespace MyProject.DataAccessLayer.Abstract
{
	
        public interface IGenericDal<T> where T : class,IEntity,new()
        {
            List<T> GetListAll(Expression<Func<T,bool>> filter=null);
            T GetById(Expression<Func<T,bool>> filter);
            void Insert(T entity);
            void Delete(int id);
            void Update(T entity);
            
           
        }
    
}

