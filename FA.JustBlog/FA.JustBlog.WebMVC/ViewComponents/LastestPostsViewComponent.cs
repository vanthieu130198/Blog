using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.ViewComponents
{
    public class LastestPostsViewComponent : ViewComponent
    {
        private readonly IPostRepository _postRepository;
        public LastestPostsViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("LastestPosts", _postRepository.GetAllByConditions(orderBy: a => a.OrderByDescending(p => p.PublishDate)));
        }
    }
}
