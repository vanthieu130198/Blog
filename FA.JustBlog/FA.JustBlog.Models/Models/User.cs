﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models.Models
{
    public class User: IdentityUser
    {
        public int Age { get; set; }
        public string AboutMe { get; set; }
        public bool Sex { get; set; }
        public string UrlFacebook { get; set; }
    }
}
