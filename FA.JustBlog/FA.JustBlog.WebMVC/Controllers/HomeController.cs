using FA.JustBlog.DataAccess.IRepositories;
using FA.JustBlog.Models.Models;
using FA.JustBlog.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepository _postRepository;
        private readonly ICommentRepository _commentRepository;
        public HomeController(ILogger<HomeController> logger, IPostRepository postRepository, ICommentRepository commentRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
            _commentRepository = commentRepository;
        }

        public IActionResult Index()
        {
            
            return View(_postRepository.GetAllByConditions(orderBy: a => a.OrderByDescending(p => p.ViewCount)));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult AddComment(CommentViewModel comment)
        {
            var cmt = new Comment()
            {
                CommentText = comment.content,
                PostId = new Guid(comment.postId),
                Name = "Anonymous",
                CommentTime = DateTime.Now
            };
            _commentRepository.Add(cmt);
            return Json(new { success = true, cmt = comment.content });
        }
    }
    public class CommentViewModel
    {
        public string content { get; set; }
        public string postId { get; set; }
    }
}
