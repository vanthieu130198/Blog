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
    public class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(cp => new { cp.PostId, cp.TagId });
            builder.HasOne(pt => pt.Post).WithMany(p => p.PostTags).HasForeignKey(fk => fk.PostId);
            builder.HasOne(pt => pt.Tag).WithMany(p => p.PostTags).HasForeignKey(fk => fk.TagId);

            builder.HasData(
                new PostTag()
                {
                    PostId = new Guid("FA680590-599C-4B70-A3ED-3DC42F0A79C6"),
                    TagId = new Guid("E36B9BAB-596C-47DA-90CA-99999E8881A2")
                },
                new PostTag()
                {
                    PostId = new Guid("6C6F1427-8E1C-4A5A-A53C-5EA5D040E080"),
                    TagId = new Guid("27E03338-543D-4C60-9CCC-2F8DA894980C")
                },
                new PostTag()
                {
                    PostId = new Guid("B11D633C-6C67-47AA-8FF5-36F219473A73"),
                    TagId = new Guid("732C6995-D666-4B24-B7FF-5E7538F49975")
                },
                new PostTag()
                {
                    PostId = new Guid("6C6F1427-8E1C-4A5A-A53C-5EA5D040E080"),
                    TagId = new Guid("87D23734-54FF-43E3-A4E2-2E05A4384AF0")
                },
                new PostTag()
                {
                    PostId = new Guid("2DA4DF58-D2B8-4442-97C1-6B43E6BB520D"),
                    TagId = new Guid("E36B9BAB-596C-47DA-90CA-99999E8881A2")
                });
        }
    }
}
