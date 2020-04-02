using System;
using System.Collections.Generic;
using System.Text;

namespace BlogBL.BLModels
{
    public class ArticleBL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
       
    }
}
