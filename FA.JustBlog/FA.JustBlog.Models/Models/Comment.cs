using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class Comment : BaseClass
    {
        public Guid CommentId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CommentHeader { get; set; }
        public string? CommentText { get; set; }
        public DateTime CommentTime { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
