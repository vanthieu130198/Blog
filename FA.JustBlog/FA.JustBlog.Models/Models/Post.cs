using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class Post : BaseClass
    {
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string PostContent { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PublishDate { get; set; }
        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int Totalrate { get; set; }
        [Display(Name = "Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IList<PostTag> PostTags { get; set; }
        public IList<Comment> Comments { get; set; }

    }
}
