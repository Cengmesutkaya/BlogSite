using BlogSite.BussinessLayer;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class AuthorController : Controller
    {
        ArticleManager repoArticle = new ArticleManager();
        AuthorManager repoAuthor = new AuthorManager();
        public ActionResult Index(string authorName)
        {
            if (authorName == null)
            {
                return RedirectToAction("", "");
            }
            List<ArticleByCategory> _articleByCategory;
            _articleByCategory = (from article in repoArticle.List()
                                  where authorName == Utils.UrlDuzenleme.UrlCevir(article.Author).ToLower()
                                  select new ArticleByCategory
                                  {
                                      ArticleCategory = article.CategorName,
                                      ArticleDate = article.ArticleDate,
                                      ArticleReading = article.ReadingCount,
                                      ArticleUrl = article.ArticleUrl,
                                      AuthorName = article.Author,
                                      Content = article.Content,
                                      Title = article.Title,
                                      ImageUrl = article.ImageUrl
                                  }).ToList();
            ViewBag.Title = "BlogSite | " + _articleByCategory.FirstOrDefault().AuthorName;

            return View(_articleByCategory);
        }

        public ActionResult AuthorArea(string authorName)
        {
            AuthorModel _authorModel = (from author in repoAuthor.List()
                                        where Utils.UrlDuzenleme.UrlCevir(author.NameSurname).ToLower() == authorName
                                        select new AuthorModel
                                        {
                                            AuthorAbout = author.AuthorAbout,
                                            AuthorFacebook = author.FacebookAdress,
                                            AuthorImage = author.Image,
                                            AuthorInstagram = author.InstagramAdress,
                                            AuthorName = author.NameSurname,
                                            AuthorTwitter = author.TwitterAdress
                                        }).FirstOrDefault();
            return View(_authorModel);
        }
    }
}