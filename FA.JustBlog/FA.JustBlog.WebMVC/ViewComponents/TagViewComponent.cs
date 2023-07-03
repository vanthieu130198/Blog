using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.ViewComponents
{
    public class TagViewComponent: ViewComponent
    {
        private readonly ITagRepository _tagRepository;
        public TagViewComponent(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ListTags", _tagRepository.GetAll());
        }
    }
}
