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
    public class TagsController : Controller
    {
        private readonly ITagRepository _tagRepository;

        public TagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        // GET: Admin/Tags
        [Authorize(Roles = "Contributor,Blog Owner, User")]
        public IActionResult Index()
        {
            return View(_tagRepository.GetAll());
        }

        // GET: Admin/Tags/Details/5
        [Authorize(Roles = "Contributor,Blog Owner, User")]
        public IActionResult Details(Guid id)
        {


            var tag = _tagRepository.GetById(id);
            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // GET: Admin/Tags/Create
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create([Bind("TagId,Name,UrlSlug,Description,Count,IsDeleted,InsertAt,UpdateAt")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                tag.TagId = Guid.NewGuid();
                _tagRepository.Add(tag);
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Admin/Tags/Edit/5
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id)
        {
            var tag = _tagRepository.GetById(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // POST: Admin/Tags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id, [Bind("TagId,Name,UrlSlug,Description,Count,IsDeleted,InsertAt,UpdateAt")] Tag tag)
        {
            if (id != tag.TagId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _tagRepository.Update(tag);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TagExists(tag.TagId))
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
            return View(tag);
        }

        // GET: Admin/Tags/Delete/5
        [Authorize(Roles = "Blog Owner")]
        public IActionResult Delete(Guid id)
        {
            var tag = _tagRepository.GetById(id);
            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // POST: Admin/Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Blog Owner")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var tag = _tagRepository.GetById(id);
            _tagRepository.Remove(tag);
            return RedirectToAction(nameof(Index));
        }

        private bool TagExists(Guid id)
        {
            return _tagRepository.GetAll().Any(e => e.TagId == id);
        }
    }
}
