using Microsoft.AspNetCore.Identity;

namespace MyBlog.EntityLayer.Concrete;

public class AppRole:IdentityRole<int>
{
    public string? RoleDetail { get; set; }
    
}