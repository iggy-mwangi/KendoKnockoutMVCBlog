﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoKnockoutBlog.Models
{
    public class BlogPost
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Excerpts { get; set; }
        public string Content { get; set; }
    }
}