using BlogBL.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interface
{
    public interface IArticleService
    {
        IEnumerable<ArticleBL> GetArticles();
        void EditArticle(ArticleBL articleBL);
    }
}
