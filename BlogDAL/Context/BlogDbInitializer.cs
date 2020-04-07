using System.Data.Entity;
using BlogDAL.Entities;


namespace BlogDAL.Context
{
    internal class BlogDbInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article { Title = "Sport", SubTitle = "New's EURO 2020", Body = "Champion " });
            db.Articles.Add(new Article { Title = "Sport", SubTitle = "Shakhtar", Body = "Shakhtar football club" });
            db.Authors.Add(new Author { FirstName = "Vasya", LastName = "Pupkin", NickName = "Pup" });
            db.Authors.Add(new Author { FirstName = "Alyosha", LastName = "Kravc", NickName = "Lyoha" });

            db.SaveChanges();
            {
            }
        }
    }
}