using BlogBL.BLModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBL.Interface
{
   public interface IArticleService
    {
        void MakeComment(CommentBL commetBL);
        ArticleBL GetArticle(int? id);
        IEnumerable<ArticleBL> GetArticles();
        void Dispose();
    }
}
