using FA.JustBlog.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.IRepositories
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        Post Detail(int year, int month, string title);
        IEnumerable<Post> GetPostsByCategoryName(string name);
        IEnumerable<Post> GetPostsByTagName(string name);
        IQueryable<Post> LatestPosts();
        IEnumerable<Post> MostViewedPosts();
        IEnumerable<Post> MostInterestingPosts();
        IEnumerable<Post> PublishedPosts();
        IEnumerable<Post> UnPublishedPosts();
    }
}
