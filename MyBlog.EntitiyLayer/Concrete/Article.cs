using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.EntitiyLayer.Concrete
{
	public class Article: IEntity
    {
		public Article()
		{
		}
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public string ThumbImageUrl { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

