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
    public class AuthorRepository : IRepository<Author>
    {
        private BlogContext db;
        public AuthorRepository(BlogContext context)
        {
            this.db = context;
        }
        public IEnumerable<Author> GetAll()
        {
            return db.Authors.Include(o => o.Articles);
        }
        public Author Get(int id)
        {
            return db.Authors.Find(id);
        }
        public void Create(Author author)
        {
            db.Authors.Add(author);
        }
        public void Update(Author author)
        {
            db.Entry(author).State = EntityState.Modified;
        }
        public IEnumerable<Author> Find(Func<Author, Boolean> predicate)
        {
            return db.Authors.Include(o => o.Articles).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Author author = db.Authors.Find(id);
            if (author != null)
                db.Authors.Remove(author);
        }
    }
}

