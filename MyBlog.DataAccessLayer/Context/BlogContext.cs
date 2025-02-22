using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Context;

public class BlogContext:IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog =MyBlogDb; User ID = SA; Password = Yasinyaman.43; Connect Timeout = 10; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Category>   Categories { get; set; }
    public DbSet<Comment>   Comments { get; set; }
    public DbSet<Tag>   Tags { get; set; }
    public DbSet<Writer>   Writers { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
}