using FA.JustBlog.DataAccess.IRepositories;
using FA.JustBlog.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostAdminController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PostAdminController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }
        [Authorize(Roles = "Contributor,Blog Owner,User")]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult LatestPosts()
        {
            return View(_postRepository.LatestPosts());
        }

        public IActionResult MostViewedPosts()
        {
            return View(_postRepository.MostViewedPosts());
        }

        public IActionResult MostInterestingPosts()
        {
            return View(_postRepository.MostInterestingPosts());
        }
        [Authorize(Roles = "Blog Owner")]
        public IActionResult PublishedPosts()
        {
            return View(_postRepository.PublishedPosts());
        }
        [Authorize(Roles = "Blog Owner")]

        public IActionResult UnPublishedPosts()
        {
            return View(_postRepository.UnPublishedPosts());
        }
        [Authorize(Roles = "Contributor,Blog Owner,User")]
        // GET: Admin/Posts/Details/5
        public IActionResult Details(Guid id)
        {
            var post = _postRepository.GetById(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create([Bind("PostId,Title,ShortDescription,ImageUrl,PostContent,UrlSlug,Published,PublishDate,CategoryId,IsDeleted,InsertAt")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.PostId = Guid.NewGuid();
                _postRepository.Add(post);
                return RedirectToAction(nameof(Index), "HomeAdmin");
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name", post.CategoryId);
            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id)
        {

            var post = _postRepository.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAll(), "CategoryId", "CategoryId", post.CategoryId);
            return View(post);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id, [Bind("PostId,Title,ShortDescription,ImageUrl,PostContent,UrlSlug,Published,PublishDate,ViewCount,RateCount,Totalrate,CategoryId,IsDeleted,InsertAt,UpdateAt")] Post post)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _postRepository.Update(post);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
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
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAll(), "CategoryId", "CategoryId", post.CategoryId);
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Blog Owner")]
        // Post: Admin/Posts/Delete/5
        public IActionResult Delete(string id)
        {
            var post = _postRepository.GetById(new Guid(id));
            if (post != null)
            {
                _postRepository.Remove(post);
            }

            return Json(new { success = true });
        }

        private bool PostExists(Guid id)
        {
            return _postRepository.GetById(id) != null ? true : false;
        }
    }
}
