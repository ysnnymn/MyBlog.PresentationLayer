using MyBlog.EntitiyLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.Context;
using MyProject.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal:GenericRepository<SocialMedia,BlogContext>,ISocialMediaDal
    {
    }
}
