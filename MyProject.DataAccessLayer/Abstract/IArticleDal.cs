using System;
using MyBlog.EntitiyLayer.Concrete;


namespace MyProject.DataAccessLayer.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
	{
		List<Article> GetArticlesByWriter(int id);
	}
}

