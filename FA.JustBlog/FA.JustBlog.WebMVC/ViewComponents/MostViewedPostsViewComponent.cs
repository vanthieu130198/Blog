using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.WebMVC.ViewComponents
{
    public class MostViewedPostsViewComponent: ViewComponent
    {
        private readonly IPostRepository _postRepository;
        public MostViewedPostsViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("MostViewedPosts", _postRepository.GetAllByConditions(orderBy: a => a.OrderByDescending(p => p.ViewCount)));
        }
    }
}
