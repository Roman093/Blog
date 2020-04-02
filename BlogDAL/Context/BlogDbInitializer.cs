using System;
using System.Data.Entity;
using BlogDAL.Entities;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Context
{
    public class BlogDbInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article { Title = "Sport", SubTitle = "New Champion UEFA", Body = "Barcelona 5 UEFA Champions League titles, a record 4 UEFA Cup Winners'" });
            db.Articles.Add(new Article { Title = "Sport", SubTitle = "New's EURO 2020", Body = "more here https://www.uefa.com/uefaeuro-2020/ " });
            db.Articles.Add(new Article { Title = "Sport", SubTitle = "Shakhtar ready to send club plane to China to evacuate Ukrainians – Pyatov", Body = "Shakhtar football club has announced its readiness to send a club plane to evacuate the Ukrainians remaining in China, the Shakhtar press service reported with reference to the club captain Andriy Pyatov." });

            db.SaveChanges();
            {
            }
        }
    }
}
