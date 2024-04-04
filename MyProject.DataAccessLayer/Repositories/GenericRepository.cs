using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyBlog.EntitiyLayer.Abstract;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;

namespace MyProject.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(int id)
        {
            using(TContext context=new TContext())
            {
                var value = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(value);
                context.SaveChanges();
            } 
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using(TContext context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetListAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext context=new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var insertEntity = context.Entry(entity);
                insertEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

