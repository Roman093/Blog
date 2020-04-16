using AutoMapper;
using BlogBL.BLModels;
using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Service
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<Author, AuthorBL>().ReverseMap();
            CreateMap<Article, ArticleBL>().ReverseMap();
        }
    }
}

