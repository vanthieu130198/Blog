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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(JustBlogContext justBlogContext) : base(justBlogContext)
        {

        }

    }
}
