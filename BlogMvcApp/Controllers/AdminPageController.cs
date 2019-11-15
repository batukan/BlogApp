using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminPageController : Controller
    {
        // GET: AdminPage
        public ActionResult Index()
        {
            return View();
        }
    }
}