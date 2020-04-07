using BlogDAL.Context;
using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Create(Article page)
        {
            db.Articles.Add(page);
        }
        public void Update(Article page)
        {
            db.Entry(page).State = EntityState.Modified;
        }
        public IEnumerable<Article> Find(Func<Article, Boolean> predicate)
        {
            return db.Articles.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Article page = db.Articles.Find(id);
            if (page != null)
                db.Articles.Remove(page);
        }
    }
}
