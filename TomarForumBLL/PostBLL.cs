﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TomarForumBLL.Interfaces;
using TomarForumData.EntityModels;
using TomarForumService.Interfaces;
using TomarForumViewModel.AdminViewModels;
using TomarForumViewModel.PostViewModels;
using TomarForumViewModel.ReplyViewModels;

namespace TomarForumBLL
{
    public class PostBLL:IPostBLL
    {
        private readonly IPostService _postService;
        private readonly IForumService _forumService;
        private static UserManager<ApplicationUser> _userManager;

        public PostBLL(IPostService postService, IForumService forumService, UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _userManager = userManager;
            _forumService = forumService;
        }

        public ActionResult<PostIndexViewModel> GetPostIndexViewModel(int? id, ClaimsPrincipal claimsPrincipal)
        {
            var post = _postService.GetById(id.Value);
            var replies = BuildPostReplies(post.Replies);

            return new PostIndexViewModel
            {
                 Id = post.Id,
                 PostTitle = post.Title,
                 AuthorId = post.User.Id,
                 AuthorName = post.User.UserName,
                 AuthorImageUrl = post.User.ProfileImageUrl,
                 AuthorRating = post.User.Rating,
                 DateCreated = post.DateCreated,
                 PostContent = post.Content,//Try to correct this naming!!! One of them is PostContent and one of the is only content.
                 Replies = replies,
                 ForumId = post.Forum.Id,
                 ForumTitle = post.Forum.Title,
                 IsAuthorAdmin = CheckAuthorAuthorization(post.User)
             };
        }

        public ActionResult<PostEditViewModel> GetPostEditViewModel(int? id, ClaimsPrincipal claimsPrincipal)
        {
            if (id is null)
            {
                return new BadRequestResult();
            }

            var postId = id.Value;

            var post = _postService.GetById(postId);

            if (post is null)
            {
                return new NotFoundResult();
            }

            else
            {
                return new PostEditViewModel
                {
                    Post=post,
                };
            }

        }

        public async Task<ActionResult<PostEditViewModel>> UpdatePost(PostEditViewModel postEditViewModel, ClaimsPrincipal claimsPrincipal)
        {
            var post = _postService.GetById(postEditViewModel.Post.Id);

            if (post == null)
                return new NotFoundResult();

            post.Title = postEditViewModel.Post.Title;
            post.Content = postEditViewModel.Post.Content;

            return new PostEditViewModel
            {
                Post = await _postService.Update(post)
            };
        }

        public async Task<PostUserViewModel> GetAdminPosts(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await _userManager.GetUserAsync(claimsPrincipal);

            return new PostUserViewModel
            {
                Posts = _postService.GetPostsByUser(applicationUser)
            };
        }

        public Post BuildPost(NewPostViewModel newPostViewModel, ApplicationUser user)
        {
            var forum = _forumService.GetById(newPostViewModel.ForumId);

            return new Post
            {
                Title = newPostViewModel.Title,
                Content = newPostViewModel.Content,
                DateCreated = DateTime.Now,
                User = user,
                Forum = forum
            };
        }

        private bool CheckAuthorAuthorization(ApplicationUser user)
        {
            return _userManager.GetRolesAsync(user).Result.Contains("Admin");
        }

        private IEnumerable<PostReplyViewModel> BuildPostReplies(IEnumerable<TomarForumData.EntityModels.PostReply> replies)
        {
            return replies.Select(reply => new PostReplyViewModel
            {
                Id = reply.Id,
                AuthorName = reply.User.UserName,
                AuthorId = reply.User.Id,
                AuthorImageUrl = reply.User.ProfileImageUrl,
                AuthorRating = reply.User.Rating,
                DateCreated = reply.DateCreated,
                ReplyContent = reply.Content,//Try to correct this naming!!! One of them is ReplyContent and one of the is only content.
                IsAuthorAdmin = CheckAuthorAuthorization(reply.User)
            });
        }

    }
}
