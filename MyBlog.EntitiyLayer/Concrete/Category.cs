using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.EntitiyLayer.Concrete
{
	public class Category: IEntity
    {
		public int CategoryId { get; set; }
		public string? CategoryName { get; set; }
         
	}
}

