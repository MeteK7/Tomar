﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomarForumViewModel.PostViewModels
{
    public class NewPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ForumTitle { get; set; }//Forum name or title??????
        public string ForumImageUrl { get; set; }
        public int ForumId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public string AuthorName { get; set; }
    }
}
