using FA.JustBlog.DataAccess.IRepositories;
using FA.JustBlog.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        public CommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpPost]
        public IActionResult AddComment()
        {
            //var cmt = new Comment()
            //{
            //    CommentText = content,
            //    PostId = new Guid(postId),
            //    Name = "Anonymous",
            //    CommentTime = DateTime.Now
            //};
            //_commentRepository.Add(cmt);
            return View(new { success = true, cmt = "" });
        }
    }
}

