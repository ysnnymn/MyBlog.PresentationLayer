using System;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;

namespace MyProject.DataAccessLayer.EntityFramework
{
	public class EfArticleDal:GenericRepository<Article,BlogContext>,IArticleDal
	{
		public EfArticleDal()
		{
		}
	}
}

