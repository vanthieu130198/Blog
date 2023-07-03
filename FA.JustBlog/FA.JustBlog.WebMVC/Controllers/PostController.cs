using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View(_postRepository.GetAllByConditions(orderBy: a => a.OrderByDescending(p => p.PublishDate)));
        }
        public IActionResult Detail(int year, int month, string title)
        {
            return View(_postRepository.Detail(year, month, title));
        }
        public IActionResult GetListPostsByCategoryName(string name)
        {
            ViewBag.CategoryName = name;
            return View(_postRepository.GetPostsByCategoryName(name));
        }
        public IActionResult GetListPostsByTagName(string name)
        {
            ViewBag.TagName = name;
            return View(_postRepository.GetPostsByTagName(name));
        }
    }
}
