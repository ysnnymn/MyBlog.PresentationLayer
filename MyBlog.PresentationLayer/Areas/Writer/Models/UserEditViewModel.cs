namespace MyBlog.PresentationLayer.Areas.Writer.Models;

public class UserEditViewModel
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string City { get; set; }
    public string ImageUrl { get; set; }
    public string UserName { get; set; }
    public string Email  { get; set; }
    public string Password { get; set; }
    public string Phonenumber { get; set; }
    public IFormFile Image { get; set; }
    
}