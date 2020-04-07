using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }

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
