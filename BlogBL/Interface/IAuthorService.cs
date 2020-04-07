using BlogBL.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interface
{
    public interface IAuthorService
    {
        void Create(AuthorBL authorBL);
        ArticleBL GetArticle(int? id);
        IEnumerable<ArticleBL> GetArticle();
        void Dispose();
    }
}
