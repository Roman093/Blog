using BlogDAL.Entities;
using BlogDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Iterface
{
    public interface IPageRepository : IDisposable
    {
        IRepository<Article> Articles { get; }
        IRepository<Author> Authors { get; }
        IEnumerable<Author> GetAuthors();
        void Save();
    }
}
