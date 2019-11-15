﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; } //foreign key
    }
}