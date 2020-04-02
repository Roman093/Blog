using BlogBL.BLModels;
using BlogBL.Interface;
using BlogDAL.Entities;
using BlogDAL.Interface;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Text;

namespace BlogBL.Service
{
   public class ArticleService : IArticleService
    {
       IPageRepository Database { get; set; }

        public ArticleService(IPageRepository uow)
        {
            Database = uow;
        }
        public void MakeComment(CommentBL commentBL)
        {
            Article article = Database.Articles.Get(commentBL.ArticleId);

            Comment comment = new Comment
            {
                Date = DateTime.Now,
                Body = commentBL.Body,
                ArticleId = article.Id,
                
                
            };
            Database.Comments.Create(comment);
            Database.Save();
        }
        public IEnumerable<ArticleBL> GetArticles()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Article, ArticleBL>()).CreateMapper();
            return mapper.Map<IEnumerable<Article>, List<ArticleBL>>(Database.Articles.GetAll());
        }
        public ArticleBL GetArticle(int? id)
        {
            var article = Database.Articles.Get(id.Value);
            //if (article == null)
            //    throw new ValidationException("Статья не найдена", "");
            return new ArticleBL { Title = article.Title, Id = article.Id, SubTitle = article.SubTitle, Body = article.Body };

        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
