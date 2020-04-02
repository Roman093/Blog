using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;
using BlogDAL.Entities;

namespace BlogDAL.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new BlogDbInitializer());
        }
        public BlogContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
