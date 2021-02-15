﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TomarForum.Models;
using TomarForumData.EntityModels;
using TomarForumService.Interfaces;
using TomarForumUI.ViewModels.ForumViewModels;
using TomarForumUI.ViewModels.HomeViewModels;
using TomarForumUI.ViewModels.PostViewModels;

namespace TomarForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeIndexViewModel();
            return View(model);
        }

        private HomeIndexViewModel BuildHomeIndexViewModel()
        {
            var latestPosts = _postService.GetLatestPosts(22);

            var posts = latestPosts.Select(post => new PostListViewModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted=post.DateCreated.ToString(),
                ReplyAmount=post.Replies.Count(),
                Forum=GetForumListingForPost(post)
            });

            return new HomeIndexViewModel
            {
                LatestPosts = posts,
                SearchQuery=""
            };
        }

        private ForumListViewModel GetForumListingForPost(Post post)
        {
            var forum = post.Forum;

            return new ForumListViewModel
            {
                Id=forum.Id,
                Title=forum.Title,
                ImageUrl=forum.ImageUrl
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
