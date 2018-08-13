using BlogSite.BussinessLayer;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class CategoryController : Controller
    {
        ArticleManager repoArticle = new ArticleManager();
        public ActionResult Index(string CategoryName)
        {
            if (CategoryName == null)
            {
                return RedirectToAction("","");
            }
            List<ArticleByCategory> _articleByCategory;
            _articleByCategory = (from article in repoArticle.List()
                                  where CategoryName == Utils.UrlDuzenleme.UrlCevir(article.CategorName).ToLower()
                                  select new ArticleByCategory
                                  {
                                      ArticleCategory = article.CategorName,
                                      ArticleDate = article.ArticleDate,
                                      ArticleReading =article.ReadingCount,
                                      ArticleUrl = article.ArticleUrl,
                                      AuthorName = article.Author,
                                      Content = article.Content,
                                      Title = article.Title,
                                      ImageUrl = article.ImageUrl
                                  }).ToList();
            ViewBag.Title = "BlogSite | " + _articleByCategory.FirstOrDefault().ArticleCategory;

            return View(_articleByCategory);
        }
    }
}