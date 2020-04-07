using AutoMapper;
using BlogBL.BLModels;
using BlogBL.Interface;
using BlogDAL.Entities;
using BlogDAL.Iterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Service
{
    public class AuthorService : IAuthorService
    {
         IPageRepository Database { get; set; }

        public AuthorService(IPageRepository uow)
        {
            Database = uow;
        }
        public void Create (AuthorBL authorBL)
        {
            Article article = Database.Articles.Get(authorBL.ArticleId);

           
            Author author = new Author
            {
                
                FirstName = authorBL.FirstName,
                LastName = authorBL.LastName,
                NickName = authorBL.NickName,

            };
            Database.Authors.Create(author);
            Database.Save();
        }
        public IEnumerable<ArticleBL> GetArticle()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Article, ArticleBL>()).CreateMapper();
            return mapper.Map<IEnumerable<Article>, List<ArticleBL>>(Database.Articles.GetAll());
        }
        public ArticleBL GetArticle(int? id)
        {
            //if (id == null)
            //    throw new ValidationException("Не установлено id телефона", "");
            var article = Database.Articles.Get(id.Value);
            //if (article == null)
            //    throw new ValidationException("Телефон не найден", "");
            return new ArticleBL { Title = article.Title, SubTitle = article.SubTitle, Body = article.Body, Id = article.Id };

        }
        public void Dispose()
        {
        Database.Dispose();
        }
    }
}
