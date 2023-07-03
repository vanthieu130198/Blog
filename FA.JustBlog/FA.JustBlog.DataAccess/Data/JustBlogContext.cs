using FA.JustBlog.DataAccess.Configurations;
using FA.JustBlog.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.Data
{
    public class JustBlogContext: IdentityDbContext<User>
    {
        public JustBlogContext()
        {

        }
        public JustBlogContext(DbContextOptions<JustBlogContext> options)
            :base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagConfiguration());
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "ED09F0E5-6627-4EE4-94DC-A446B52921B0",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole()
                {
                    Id = "A7F098E4-D8F9-43EF-BAD6-65034FDEDC45",
                    Name = "Contributor",
                    NormalizedName = "Contributor".ToUpper()
                },
                new IdentityRole()
                {
                    Id = "B6812DFE-3F6B-4128-90B3-DE050C5FFF46",
                    Name = "Blog Owner",
                    NormalizedName = "Blog Owner".ToUpper()
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id= "590c7a5d-7c2f-485d-f27a-08d9b894db0a",
                    UserName = "test@gmail.com",
                    NormalizedUserName = "TEST@GMAIL.COM",
                    Email = "test@gmail.com",
                    NormalizedEmail = "test@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAELY90+pWj8esXEfaKBnDxvpflRSfxGtA3ywCXlRREccwMRfM5cB70qbe4quz5biOAg==",
                    SecurityStamp = "XSH4GERHMS5GC6F4OQD6P62EO5LQWM33",
                    ConcurrencyStamp = "7c881424-62e0-4e52-b0b2-0b9500783a9a"
                }
                );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>()
                {
                    RoleId = "ED09F0E5-6627-4EE4-94DC-A446B52921B0",
                    UserId = "590c7a5d-7c2f-485d-f27a-08d9b894db0a"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "A7F098E4-D8F9-43EF-BAD6-65034FDEDC45",
                    UserId = "590c7a5d-7c2f-485d-f27a-08d9b894db0a"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "B6812DFE-3F6B-4128-90B3-DE050C5FFF46",
                    UserId = "590c7a5d-7c2f-485d-f27a-08d9b894db0a"
                }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration config = new ConfigurationBuilder()
                                         .AddJsonFile("appSettings.json")
                                         .Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("JustBlog"));
            }
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostTag> PostTags { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
