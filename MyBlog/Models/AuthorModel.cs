using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Enter your first name")]
        [MinLength (2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [MinLength(2)]
        public string LastName { get; set; }

        [MinLength(2)]
        public string NickName { get; set; }

        public List<ArticleModel> ArticleModel { get; set; }
    }
}