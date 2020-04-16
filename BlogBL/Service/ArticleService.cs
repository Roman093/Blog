using AutoMapper;
using BlogBL.BLModels;
using BlogBL.Interface;
using BlogDAL.Entities;
using BlogDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository<Article> _repository;
        private readonly IMapper _mapper;

        public ArticleService(IRepository<Article> articleRepository, IMapper mapper)
        {
            _repository = articleRepository;
            _mapper = mapper;
        }

        public IEnumerable<ArticleBL> GetArticles()
        {
            var articles = _mapper.Map<IEnumerable<ArticleBL>>(_repository.GetAll());

            return articles;
        }

        public void EditArticle(ArticleBL articleBL)
        {
            var article = _mapper.Map<Article>(articleBL);

            _repository.Update(article);
        }
    }
}

