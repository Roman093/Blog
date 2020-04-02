﻿using BlogDAL.Context;
using BlogDAL.Entities;
using BlogDAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Repository
{
    public class PageRepository : IPageRepository
    {
        private BlogContext db;
        private ArticleRepository articleRepository;
        private CommentRepository commentRepository;

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

        public IRepository<Comment> Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
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
    }
}
