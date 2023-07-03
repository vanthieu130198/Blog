using FA.JustBlog.DataAccess.Data;
using FA.JustBlog.DataAccess.IRepositories;
using FA.JustBlog.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.Repositories
{
    public class PostTagRepository : BaseRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(JustBlogContext justBlogContext) : base(justBlogContext)
        {

        }
    }
}
