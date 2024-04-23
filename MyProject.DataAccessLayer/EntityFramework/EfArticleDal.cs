using System;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;

namespace MyProject.DataAccessLayer.EntityFramework
{
	public class EfArticleDal:GenericRepository<Article,BlogContext>,IArticleDal
	{
        BlogContext context=new BlogContext();
		public EfArticleDal()
		{
		}

        public List<Article> GetArticlesByWriter(int id)
        {
            var values=context.Articles.Where(x=>x.AppUserId==id).ToList();
            return values;
        }
    }
}

