using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Html And Css",Description="Html And Css Tutorials"},
                new Category(){Name="C# Delegates",Description="About C# Delegates"},
                new Category(){Name="Data Structures And Algorithms",Description="Data structures and algorithms in C++"},
                new Category(){Name="Javascript",Description="Javascript's Framework"},
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();

            var blogs = new List<Blog>()
            {
                new Blog(){Title="Html And Css",Description=" Html And Css Tutorials Html And Css Tutorials Html And Css Tutorials Html And Css Tutorials Html And Css Tutorials",CategoryId=1,IsHome=true,IsApproved=true,Image="1.jpg"},
                new Blog(){Title="Html And Css",Description="Html And Css Form Group",CategoryId=1,IsHome=false,IsApproved=true,Image="2.jpg"},
                new Blog(){Title="C# Delegates",Description="About C# Delegates",CategoryId=2,IsHome=true,IsApproved=true,Image="2.jpg"},
                new Blog(){Title="Data structures and algorithms",Description="Data structures and algorithms in C++",CategoryId=3,IsHome=true,IsApproved=true,Image="3.jpg"},
            };

            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            }

            context.SaveChanges();


            base.Seed(context);
        }
    }
}