using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ArticleDate { get; set; }
        public string ArticleUrl { get; set; }
        public string ArticleCategory { get; set; }

        public string[] ArticleTags { get; set; }

        public int ArticleReading { get; set; }

        public string AuthorName { get; set; }

        public string AuthorAbout { get; set; }

        public string AuthorFacebook { get; set; }

        public string AuthorTwitter{ get; set; }

        public string AuthorInstagram { get; set; }

        public string AuthorImageUrl { get; set; }


    }
}