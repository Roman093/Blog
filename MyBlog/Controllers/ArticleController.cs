using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View("~/Views/Article/Article.cshtml");
        }

        [ChildActionOnly]
        public ActionResult Add()
        {
            ViewBag.Title = "I am from Add action";

            return PartialView("~/Views/Partial/AddForm.cshtml");
        }
    }
}