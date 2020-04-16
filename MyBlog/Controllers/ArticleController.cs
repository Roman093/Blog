using AutoMapper;
using BlogBL.Interface;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _service = articleService;
            _mapper = mapper;
        }
        // GET: Article
        public ActionResult Index()
        {
            var articles = _mapper.Map<List<ArticleModel>>(_service.GetArticles());
            ViewBag.Message = "Articles";
            return View(articles);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return RedirectToAction("Index");
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// POST: Article/Edit/5
        //[HttpPost]
        //public ActionResult Edit(ArticleModel articleModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(articleModel);
        //    }
        //    var resultMap = _mapper.Map<ArticleModel>(articleModel);
        //    _service.EditArticle(resultMap);
        //    return RedirectToAction("Index");
        //}

        // GET: Article/Delete/5
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
    }
}