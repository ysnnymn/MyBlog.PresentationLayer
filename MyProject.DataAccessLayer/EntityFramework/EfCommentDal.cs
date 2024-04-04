using System;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;

namespace MyProject.DataAccessLayer.EntityFramework
{
	public class EfCommentDal:GenericRepository<Comment, BlogContext>,ICommentDal
	{
		public EfCommentDal()
		{
		}
	}
}

