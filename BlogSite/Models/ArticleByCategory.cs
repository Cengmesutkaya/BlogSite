using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class ArticleByCategory
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string ArticleDate { get; set; }
        public string ArticleUrl { get; set; }
        public string ArticleCategory { get; set; }
        public int ArticleReading { get; set; }
        public string AuthorName { get; set; }
    }
}