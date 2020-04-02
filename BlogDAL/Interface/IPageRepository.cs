using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Interface
{
   public interface IPageRepository:IDisposable
    {
        IRepository<Article> Articles { get; }
        IRepository<Comment> Comments { get; }
        void Save();
    }
}
