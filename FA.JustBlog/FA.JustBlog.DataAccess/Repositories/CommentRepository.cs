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
    public class CommentRepository:BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(JustBlogContext justBlogContext) : base(justBlogContext)
        {

        }
    }
}
