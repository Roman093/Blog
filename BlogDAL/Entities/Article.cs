using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDAL.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
