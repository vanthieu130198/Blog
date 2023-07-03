using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.ViewComponents
{
    public class DropdownListCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public DropdownListCategoriesViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("DropdownListCategories", _categoryRepository.GetAll());
        }
    }
}
