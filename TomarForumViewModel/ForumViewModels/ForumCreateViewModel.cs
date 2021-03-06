﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomarForumViewModel.ForumViewModels
{
    public class ForumCreateViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
        public int AmountTotalPost { get; set; }
        public int AmountTotalUser { get; set; }
    }
}
