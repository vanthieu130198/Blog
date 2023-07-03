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
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: Admin/Categories
        [Authorize(Roles = "Contributor,Blog Owner, User")]
        public IActionResult Index()
        {
            return View(_categoryRepository.GetAll());
        }

        // GET: Admin/Categories/Details/5
        [Authorize(Roles = "Contributor,Blog Owner, User")]
        public IActionResult Details(Guid id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Create([Bind("CategoryId,Name,UrlSlug,Description,IsDeleted,InsertAt,UpdateAt")] Category category)
        {
            if (ModelState.IsValid)
            {
                category.CategoryId = Guid.NewGuid();
                _categoryRepository.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id)
        {

            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Contributor,Blog Owner")]
        public IActionResult Edit(Guid id, [Bind("CategoryId,Name,UrlSlug,Description,IsDeleted,InsertAt,UpdateAt")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _categoryRepository.Update(category);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
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
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        [Authorize(Roles = "Blog Owner")]
        public IActionResult Delete(Guid id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Blog Owner")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var category = _categoryRepository.GetById(id);
            _categoryRepository.Remove(category);
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(Guid id)
        {
            return _categoryRepository.GetAll().Any(e => e.CategoryId == id);
        }
    }
}
