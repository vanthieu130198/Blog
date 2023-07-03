using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class BaseClass
    {
        public bool IsDeleted { get; set; }
        public DateTime InsertAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
