using AutoMapper;
using BlogBL.BLModels;
using BlogBL.Interface;
using BlogBL.Service;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class AuthorController : Controller
    {
        IAuthorService authorService;
        public AuthorController(IAuthorService serv)
        {
            authorService = serv;
        }
        public ActionResult Index()
        {
            IEnumerable<ArticleBL> articleBLs = authorService.GetArticle();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ArticleBL, ArticleModel>()).CreateMapper();
            var articles = mapper.Map<IEnumerable<ArticleBL>, List<ArticleModel>>(articleBLs);
            return View(articles);
        //}
        //public ActionResult Details(int id)
        //{
        //    var mapper = new MapperConfiguration(cfg => cfg.FirstOrDefault<ArticleBL, ArticleModel>()).CreateMapper();
        //    var articles = mapper.Map<IEnumerable<ArticleBL>, List<ArticleModel>>(articleBLs);

        //    return View(author);
        }
        public ActionResult Create(int? id)
        {
            try
            {
                ArticleBL article = authorService.GetArticle(id);
                var author = new AuthorModel { ArticleId = article.Id };

                return View(author);
            }
            catch (ValidationException ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult Create(AuthorModel author)
        {
            try
            {
                var authorBL = new AuthorBL { ArticleId = author.ArticleId, FirstName = author.FirstName, LastName = author.LastName, NickName = author.NickName };
                authorService.Create(authorBL);
                return Content("<h2>Completed</h2>");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(author);
        }
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            authorService.Dispose();
            base.Dispose(disposing);
        }
    }
}



//        List<AuthorBL> list;
//        public AuthorController()
//        {
//            list = new List<AuthorBL> {
//                new AuthorBL {Id=1, FirstName ="Vasya", LastName="23432", NickName= "23324432"},
//                new AuthorBL {Id=2, FirstName ="Fedya", LastName="fsdfsdsdf", NickName= "sdsdfsdsdf"},
//                new AuthorBL {Id =3, FirstName ="Dada", LastName="sdfsdf", NickName= "sdsdsdfsdffsdsdf"}
//            };
//        }
//        // GET: Author
//        public ActionResult Index()
//        {


//            return View(list);
//        }

//        // GET: Author/Details/5
//        public ActionResult Details(int id)
//        {
//            var author = list.FirstOrDefault(x => x.Id == id);
//            return View(author);
//        }

//        // GET: Author/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Author/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Author/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Author/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Author/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Author/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}