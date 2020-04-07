using BlogBL.Interface;
using BlogBL.Service;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Util
{
    public class AuthorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorService>().To<AuthorService>();
        }
    }
}
