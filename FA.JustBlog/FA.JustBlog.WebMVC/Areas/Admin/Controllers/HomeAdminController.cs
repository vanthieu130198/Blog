using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
        private readonly IPostRepository _postRepository;
        public HomeAdminController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexGrid()
        {
            return PartialView(_postRepository.LatestPosts());
        }
    }
}
