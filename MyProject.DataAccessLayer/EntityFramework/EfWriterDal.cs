using System;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;

namespace MyProject.DataAccessLayer.EntityFramework
{
	public class EfWriterDal:GenericRepository<Writer, BlogContext>,IWriterDal
	{
		public EfWriterDal()
		{
		}

        public int GetWriterCount()
        {
            return 0;
        }
    }
}

