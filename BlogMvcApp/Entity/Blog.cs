using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Entity
{
    public class Blog
    {
        public int Id { get; set; }

        [AllowHtml]
        [DisplayName("Blog Description")]
        public string Description { get; set; }
        public string Image { get; set; }

        [DisplayName("Blog Title")]
        public string Title { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
                
        public int CategoryId { get; set; } //foreign key
        public Category Category { get; set; }
        



    }
}