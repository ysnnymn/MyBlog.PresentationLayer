using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.EntitiyLayer.Concrete
{
	public class Comment: IEntity
    {
		
		public int CommentId { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool Status { get; set; }

	}
}

