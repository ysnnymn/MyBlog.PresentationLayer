using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete;

public class SocialMediaManager:ISocialMediaService
{
    ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public void TInsert(SocialMedia entity)
    {
_socialMediaDal.Insert(entity);    }

    public void TUpdate(SocialMedia entity)
    {
_socialMediaDal.Update(entity);

    }

    public void TDelete(int id)
    {
_socialMediaDal.Delete(id);

    }

    public SocialMedia TGetById(int id)
    {
return _socialMediaDal.GetById(id);

    }

    public List<SocialMedia> TGetListAll()
    {
return    _socialMediaDal.GetListAll();}
}