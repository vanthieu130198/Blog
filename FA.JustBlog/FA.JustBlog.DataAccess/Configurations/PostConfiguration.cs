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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(fk => fk.CategoryId);
            builder.HasData(
                new Post()
                {
                    PostId = new Guid("FA680590-599C-4B70-A3ED-3DC42F0A79C6"),
                    Title = "Some thing about Tea #Tea",
                    ShortDescription = "Tea is the most drink for people.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1",
                    PostContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni," +
                    " ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?",
                    UrlSlug = "Empty",
                    Published = true,
                    PublishDate = new DateTime(2021, 11, 24),
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    ViewCount = 120,
                    RateCount = 10,
                    Totalrate = 10,
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                },
                new Post()
                {
                    PostId = new Guid("B11D633C-6C67-47AA-8FF5-36F219473A73"),
                    Title = "Some thing about Coffee #Coffee",
                    ShortDescription = "Coffee is the most drink for people.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1",
                    PostContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni," +
                    " ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?",
                    UrlSlug = "Empty",
                    Published = true,
                    PublishDate = new DateTime(2021, 11, 23),
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    ViewCount = 120,
                    RateCount = 10,
                    Totalrate = 10,
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                },
                new Post()
                {
                    PostId = new Guid("6C6F1427-8E1C-4A5A-A53C-5EA5D040E080"),
                    Title = "Some thing about Milks #Milks",
                    ShortDescription = "Milks is the most drink for people.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1",
                    PostContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni," +
                    " ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?",
                    UrlSlug = "Empty",
                    Published = true,
                    PublishDate = new DateTime(2021, 11, 12),
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    ViewCount = 120,
                    RateCount = 10,
                    Totalrate = 10,
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                },
                new Post()
                {
                    PostId = new Guid("2DA4DF58-D2B8-4442-97C1-6B43E6BB520D"),
                    Title = "Some thing about Sting #Drinks",
                    ShortDescription = "Drinks is the most drink for people.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1",
                    PostContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni," +
                    " ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?",
                    UrlSlug = "Empty",
                    Published = true,
                    PublishDate = new DateTime(2021, 11, 14),
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    ViewCount = 120,
                    RateCount = 10,
                    Totalrate = 10,
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                },
                new Post()
                {
                    PostId = new Guid("96D1D69D-613A-484D-9F31-AAC1A65C17D5"),
                    Title = "Some thing about OngTho #Milks",
                    ShortDescription = "Milks is the most drink for people.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.IrCcZG0OwJUJ_6a1mhQHqwHaFZ?pid=ImgDet&rs=1",
                    PostContent = "Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni," +
                    " ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?. Lorem ipsum dolor sit amet consectetur, adipisicing elit." +
                    " Aliquid nobis dolore expedita laboriosam aliquam libero natus quas soluta sequi praesentium magni, ratione distinctio amet, aperiam, minima laborum dolorem? Molestiae, minima?",
                    UrlSlug = "Empty",
                    Published = true,
                    PublishDate = new DateTime(2021, 11, 16),
                    CategoryId = new Guid("B20C815F-5F83-449D-9102-C74B4F11DB6B"),
                    ViewCount = 5000,
                    RateCount = 7,
                    Totalrate = 8,
                    IsDeleted = false,
                    InsertAt = new DateTime(2021, 11, 24),
                    UpdateAt = new DateTime(2021, 11, 24)
                }) ;
        }
    }
}
