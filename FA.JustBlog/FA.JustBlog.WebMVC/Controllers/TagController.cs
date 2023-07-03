using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagRepository _tagRepository;
        public TagController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
