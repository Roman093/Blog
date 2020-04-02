using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBL.BLModels
{
    public class CommentBL
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int ArticleId { get; set; }
        public DateTime Date { get; set; }
    }
}
