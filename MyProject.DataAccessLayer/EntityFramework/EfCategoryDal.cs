using System;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;

namespace MyProject.DataAccessLayer.EntityFramework
{
	public class EfCategoryDal:GenericRepository<Category, BlogContext>,ICategoryDal
	{
		public EfCategoryDal()
		{
		}

	}
}

