using System;

namespace BlogDAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int AuthorId { get; set; }
        public int ArticleId { get; set; }
        public DateTime Date { get; set; }
    }
}