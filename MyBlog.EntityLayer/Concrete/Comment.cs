namespace MyBlog.EntityLayer.Concrete;

public class Comment
{
    public int CommentId { get; set; }
    public string Description { get; set; }
    public DateTime CreatedData { get; set; }
    public bool Status { get; set; }
}