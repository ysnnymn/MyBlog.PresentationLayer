using MyBlog.EntitiyLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.EntitiyLayer.Concrete
{
    public class SocialMedia : IEntity
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public string LinkUrl { get; set; }

    }
}
