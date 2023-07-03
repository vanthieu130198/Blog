using FA.JustBlog.DataAccess.Data;
using FA.JustBlog.DataAccess.IRepositories;
using FA.JustBlog.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(JustBlogContext justBlogContext) : base(justBlogContext)
        {

        }
        public Post Detail(int year, int month, string title)
        {
            var listPosts = _justBlogContext.Posts.Where(p => p.PublishDate.Year.Equals(year))
                                             .Where(p => p.PublishDate.Month.Equals(month))
                                             .Where(p => p.Title.Equals(title));
            var post = listPosts.FirstOrDefault();
            _justBlogContext.Entry(post).Collection("Comments").Load();
            return post;
        }
        public IEnumerable<Post> GetPostsByCategoryName(string name)
        {
            return _justBlogContext.Posts
                .Include(p => p.Category)
                .Include(p => p.PostTags)
                .Where(p => p.Category.Name.Equals(name)).ToList();

        }
        public IEnumerable<Post> GetPostsByTagName(string name)
        {
            var data = (from pt in _justBlogContext.PostTags
                        join p in _justBlogContext.Posts on pt.PostId equals p.PostId
                        join t in _justBlogContext.Tags on pt.TagId equals t.TagId
                        where t.Name == name
                        select p).ToList();
            return data;
        }

        public IQueryable<Post> LatestPosts()
        {
            return _justBlogContext.Posts;
        }

        // MostInterestingPost is ordered by TotalRate
        public IEnumerable<Post> MostInterestingPosts()
        {
            return GetAllByConditions(orderBy: p => p.OrderByDescending(pt => pt.Totalrate));
        }

        public IEnumerable<Post> MostViewedPosts()
        {
            return GetAllByConditions(orderBy: a => a.OrderByDescending(p => p.ViewCount));
        }

        public IEnumerable<Post> PublishedPosts()
        {
            return GetAllByConditions(filter: dt => dt.Published);
        }

        public IEnumerable<Post> UnPublishedPosts()
        {
            return GetAllByConditions(filter: dt => !dt.Published);
        }
    }
}
