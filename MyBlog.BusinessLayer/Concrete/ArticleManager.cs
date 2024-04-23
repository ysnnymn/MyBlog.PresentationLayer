using System;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;

namespace MyBlog.BusinessLayer.Concrete
{
	public class ArticleManager:IArticleService
	{
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetArticlesByWriter(int id)
        {
            return _articleDal.GetArticlesByWriter(id);
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(a=>a.ArticleId==id);
        }

        public List<Article> TGetListAll()
        {
            return _articleDal.GetListAll();
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}

