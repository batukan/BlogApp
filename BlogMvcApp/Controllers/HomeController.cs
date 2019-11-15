using BlogMvcApp.Entity;
using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        DataContext context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                      .Where(i => i.IsHome && i.IsApproved)
                      .Select(i => new BlogModel()
                      {
                          Id = i.Id,
                          Title = i.Title,
                          Description = i.Description.Length > 100 ? i.Description.Substring(0, 97) + "..." : i.Description,
                          Image = i.Image,
                          CategoryId = i.CategoryId
                      })
                      .ToList();
            return View(blogs);
        }
        [HandleError]
        public ActionResult Details(int id)
        {
            return View(context.Blogs.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult List(int? id)
        {
            var blogs = context.Blogs
                      .Where(i => i.IsApproved)
                      .Select(i => new BlogModel()
                      {
                          Id = i.Id,
                          Title = i.Title,
                          Description = i.Description.Length > 100 ? i.Description.Substring(0, 97) + "..." : i.Description,
                          Image = i.Image ?? "1.jpg",
                          CategoryId = i.CategoryId
                      })
                      .AsQueryable();            

            if (id != null)
            {
                blogs = blogs.Where(i => i.CategoryId == id);
            }

            return View(blogs.ToList());
        }
        public ActionResult Contact()
        {
            //if (!string.IsNullOrEmpty(txtName)&&!string.IsNullOrEmpty(txtMail) && !string.IsNullOrEmpty(txtPassword))
            //{

            //}
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(context.Categories.ToList());
        }
    }
}