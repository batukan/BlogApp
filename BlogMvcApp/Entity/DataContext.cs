using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataConnection")
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}