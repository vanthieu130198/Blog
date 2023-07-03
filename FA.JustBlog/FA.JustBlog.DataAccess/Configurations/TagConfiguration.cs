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
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData(
                new Tag()
                {
                    TagId = new Guid("E36B9BAB-596C-47DA-90CA-99999E8881A2"),
                    Name = "#Teas",
                    Description = "All tea will be tag #Teas.",
                    Count = 10,
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 11),
                    UpdateAt = new DateTime(2021, 11,15)
                },
                new Tag()
                {
                    TagId = new Guid("27E03338-543D-4C60-9CCC-2F8DA894980C"),
                    Name = "#Coffees",
                    Description = "All tea will be tag #Coffees.",
                    Count = 11,
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 10, 11),
                    UpdateAt = new DateTime(2021, 11, 15)
                },
                new Tag()
                {
                    TagId = new Guid("732C6995-D666-4B24-B7FF-5E7538F49975"),
                    Name = "#Drinks",
                    Description = "All tea will be tag #Drinks.",
                    Count = 12,
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 11),
                    UpdateAt = new DateTime(2021, 11, 15)
                },
                new Tag()
                {
                    TagId = new Guid("87D23734-54FF-43E3-A4E2-2E05A4384AF0"),
                    Name = "#Milks",
                    Description = "All tea will be tag #Milks.",
                    Count = 15,
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 11),
                    UpdateAt = new DateTime(2021, 11, 15)
                });
        }
    }
}
