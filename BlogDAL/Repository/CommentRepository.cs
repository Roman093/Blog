using BlogDAL.Context;
using BlogDAL.Entities;
using BlogDAL.Interface;
using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Repository
{
   public class CommentRepository : IRepository<Comment>
    {
        private BlogContext db;
        public CommentRepository(BlogContext context)
        {
            this.db = context;
        }
        public IEnumerable<Comment> GetAll()
        {
            return db.Comments.Include(o => o.AuthorId);
        }
        public Comment Get(int id)
        {
            return db.Comments.Find(id);
        }
        public void Create(Comment comment)
        {
            db.Comments.Add(comment);
        }
        public void Update(Comment comment)
        {
            db.Entry(comment).State = EntityState.Modified;
        }
        public IEnumerable<Comment> Find(Func<Comment, Boolean> predicate)
        {
            return db.Comments.Include(o => o.AuthorId).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Comment comment = db.Comments.Find(id);
            if (comment != null)
                db.Comments.Remove(comment);
        }
    }
}
