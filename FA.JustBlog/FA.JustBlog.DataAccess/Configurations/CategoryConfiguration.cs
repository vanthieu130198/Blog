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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category()
                {
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    Name = "Food or Drinks",
                    Description = "All products relate to Food or Drinks",
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                },
                new Category()
                {
                    CategoryId = new Guid("FF85E290-573F-477B-BC75-3AFEF7ACB469"),
                    Name = "Technololy",
                    Description = "All posts relate to .Net or other.",
                    UrlSlug = "Empty",
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 23),
                    UpdateAt = new DateTime(2021, 11, 23)
                }) ;
        }
    }
}
