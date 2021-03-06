﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomarForumViewModel.ReplyViewModels;

namespace TomarForumViewModel.PostViewModels
{
    public class PostIndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorRating { get; set; }
        public bool IsAuthorAdmin { get; set; }
        public DateTime DateCreated { get; set; }
        public string PostContent { get; set; }
        public int ForumId { get; set; }
        public string ForumTitle { get; set; }
        public IEnumerable<PostReplyViewModel> Replies { get; set; }
    }
}
