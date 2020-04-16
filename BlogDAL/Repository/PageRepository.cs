using BlogDAL.Context;
using BlogDAL.Entities;
using BlogDAL.Iterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Repository
{
   public class PageRepository : IPageRepository
    {
        private BlogContext db;
        private ArticleRepository articleRepository;
        private AuthorRepository authorRepository;

        public PageRepository(string connectionString)
        {
            db = new BlogContext(connectionString);
        }
        public IRepository<Article> Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }

        public IRepository<Author> Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(db);
                return authorRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
