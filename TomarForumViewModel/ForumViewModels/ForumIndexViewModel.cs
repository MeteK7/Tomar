﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomarForumViewModel.ForumViewModels
{
    public class ForumIndexViewModel
    {
        public int ForumTopicAmount { get; set; }
        public IEnumerable<ForumListViewModel> ForumList { get; set; }
    }
}
