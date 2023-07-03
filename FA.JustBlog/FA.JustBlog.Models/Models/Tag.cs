using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class Tag : BaseClass
    {
        public Guid TagId { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public IList<PostTag> PostTags { get; set; }
    }
}
