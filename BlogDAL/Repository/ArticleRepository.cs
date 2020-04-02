using BlogDAL.Entities;
using BlogDAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Repository
{
    public class ArticleRepository : IRepository<Article>
    {
        void IRepository<Article>.Create(Article item)
        {
            throw new NotImplementedException();
        }

        void IRepository<Article>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Article> IRepository<Article>.Find(Func<Article, bool> predicate)
        {
            throw new NotImplementedException();
        }

        Article IRepository<Article>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Article> IRepository<Article>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Article>.Update(Article item)
        {
            throw new NotImplementedException();
        }
    }
}
