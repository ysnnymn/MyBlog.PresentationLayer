using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(int id)
        {
           _socialMediaDal.Delete(id);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(x => x.SocialMediaId == id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialMediaDal.GetListAll();
        }

        public void TInsert(SocialMedia entity)
        {
          _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialMediaDal.Update(entity);
        }
    }
}
