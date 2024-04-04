using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.EntitiyLayer.Concrete
{
	public class Tag: IEntity
    {
		
              public int TagId { get; set; }
        public string TagTitle { get; set; }
    }
}

