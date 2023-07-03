using FA.JustBlog.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(c => c.Post).WithMany(p => p.Comments).HasForeignKey(fk => fk.PostId);
            builder.HasData(
                new Comment() 
                {
                    CommentId = new Guid("A39A34AB-67D0-4C76-9075-238DA9CB3FDE"),
                    CommentHeader = "For comments",
                    CommentText = "hahaha good",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Cáo ẩn danh",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("FA680590-599C-4B70-A3ED-3DC42F0A79C6"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("E704B5A7-9609-4D59-80C5-65578C9ED19A"),
                    CommentHeader = "For comments",
                    CommentText = "Very good",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Thỏ mũm mĩm",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("B11D633C-6C67-47AA-8FF5-36F219473A73"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("DCFF144C-4CE2-4A4D-BBA8-139790C9FB5B"),
                    CommentHeader = "For comments",
                    CommentText = "Excellent !",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Cá sấu hoa cà",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("6C6F1427-8E1C-4A5A-A53C-5EA5D040E080"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("AFA431CD-F436-4D4B-93A3-6A8D7A596223"),
                    CommentHeader = "For comments",
                    CommentText = "5 stars",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Chuột chũi đại dương",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("2DA4DF58-D2B8-4442-97C1-6B43E6BB520D"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("5D79493F-41A3-4C6F-BBA4-D457B1A20696"),
                    CommentHeader = "For comments",
                    CommentText = "Yo Yo",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Cá mập biển sâu",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("96D1D69D-613A-484D-9F31-AAC1A65C17D5"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("CAB6FB6B-D118-47B2-B862-E06A41C66AB4"),
                    CommentHeader = "For comments",
                    CommentText = "Hảo sản phẩm",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Sóc nâu",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("FA680590-599C-4B70-A3ED-3DC42F0A79C6"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                },
                new Comment()
                {
                    CommentId = new Guid("D02D4926-3AD8-47DD-B77C-714C86AB613A"),
                    CommentHeader = "For comments",
                    CommentText = "Ngon !",
                    CommentTime = new DateTime(2021, 10, 14),
                    Name = "Mèo mướp ẩn danh",
                    Email = "mous@example.com",
                    IsDeleted = false,
                    PostId = new Guid("FA680590-599C-4B70-A3ED-3DC42F0A79C6"),
                    InsertAt = new DateTime(2021, 11, 25),
                    UpdateAt = new DateTime(2021, 11, 25)
                });
        }
    }
}
