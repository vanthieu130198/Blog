using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FA.JustBlog.DataAccess.Data;
using FA.JustBlog.Models.Models;
using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Authorization;

namespace FA.JustBlog.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentsController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IPostRepository _postRepository;
        public CommentsController(ICommentRepository commentRepository,
            IPostRepository postRepository)
        {
            _commentRepository = commentRepository;
            _postRepository = postRepository;
        }

        // GET: Admin/CommentAdmin
        [Authorize(Roles = "Contributor,Blog Owner,User")]
        public IActionResult Index()
        {
            return View(_commentRepository.GetAll());
        }

        // GET: Admin/CommentAdmin/Details/5
        [Authorize(Roles = "Contributor,Blog Owner, User")]
        public IActionResult Details(Guid id)
        {

            var comment = _commentRepository.GetById(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Admin/CommentAdmin/Create
        [Authorize(Roles = "Blog Owner")]
        public IActionResult Create()
        {
            ViewData["PostId"] = new SelectList(_postRepository.GetAll(), "PostId", "PostId");
            return View();
        }

        // POST: Admin/CommentAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Blog Owner")]
        public IActionResult Create([Bind("CommentId,Name,Email,CommentHeader,CommentText,CommentTime,PostId,IsDeleted,InsertAt,UpdateAt")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CommentId = Guid.NewGuid();
                _commentRepository.Add(comment);
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_postRepository.GetAll(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // GET: Admin/CommentAdmin/Edit/5
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id)
        {
            var comment = _commentRepository.GetById(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["PostId"] = new SelectList(_postRepository.GetAll(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // POST: Admin/CommentAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id, [Bind("CommentId,Name,Email,CommentHeader,CommentText,CommentTime,PostId,IsDeleted,InsertAt,UpdateAt")] Comment comment)
        {
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _commentRepository.Update(comment);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_postRepository.GetAll(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // GET: Admin/CommentAdmin/Delete/5
        [Authorize(Roles = "Blog Owner")]
        public IActionResult Delete(Guid id)
        {
            var comment = _commentRepository.GetById(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Admin/CommentAdmin/Delete/5
        [Authorize(Roles = "Blog Owner")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var comment = _commentRepository.GetById(id);
            _commentRepository.Remove(comment);
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(Guid id)
        {
            return _commentRepository.GetAll().Any(e => e.CommentId == id);
        }
    }
}
