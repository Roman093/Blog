using BlogDAL.Entities;
using BlogDAL.Interface;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;
using BlogDAL.Context;
using System.Linq;

namespace BlogDAL.Repository
{
    public class ArticleRepository : IRepository<Article>
    {
        private BlogContext db;
        public ArticleRepository(BlogContext context)
        {
            this.db = context;
        }
        public IEnumerable<Article> GetAll()
        {
            return db.Articles;
        }
        public Article Get(int id)
        {
            return db.Articles.Find(id);
        }
        public void Create(Article book)
        {
            db.Articles.Add(book);
        }
        public void Update(Article book)
        {
            db.Entry(book).State = EntityState.Modified;
        }
        public IEnumerable<Article> Find(Func<Article, Boolean> predicate)
        {
            return db.Articles.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Article book = db.Articles.Find(id);
            if (book != null)
                db.Articles.Remove(book);
        }
    }
}
