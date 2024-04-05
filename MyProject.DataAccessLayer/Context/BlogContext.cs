using System;
using Microsoft.EntityFrameworkCore;
using MyBlog.EntitiyLayer.Concrete;

namespace MyProject.DataAccessLayer.Context
{
	public class BlogContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;initial catalog=DbMyBlog;integrated security=true");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}

