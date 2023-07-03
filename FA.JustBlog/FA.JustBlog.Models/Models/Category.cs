using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class Category : BaseClass
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string? Description { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
