﻿using Kalles.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace Kalles.WebUI.AppCode.ViewComponents
{
    public class RecentPostsViewComponent : ViewComponent
    {
        private readonly IMediator mediator;

        public RecentPostsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new BlogPostRecentQuery();
            var posts = await mediator.Send(query);
            return View(posts);
        }
    }
}
