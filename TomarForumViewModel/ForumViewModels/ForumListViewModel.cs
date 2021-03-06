﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomarForumViewModel.ForumViewModels
{
    public class ForumListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int AmountTotalPost { get; set; }
        public int AmountTotalUser { get; set; }
    }
}
