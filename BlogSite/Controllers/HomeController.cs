using BlogSite.BussinessLayer;
using BlogSite.BussinessLayer.Abstract;
using BlogSite.DataEntities;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        ArticleManager repoArticle = new ArticleManager();
        AuthorManager repoAuthor = new AuthorManager();
        public ActionResult Index()
        {
           // Test test = new Test();

            var articleList = repoArticle.List();
            ViewBag.Keywords = "Seyahat, Alışveriş,Eğlence,Saltur Blog, Saltur Turizm";
            ViewBag.Description = "1980 yılında Ankara’da kurulan Saltur Turizm bu alanda imza atmıştır.";
            ViewBag.Title = "Blog Site | Anasayfa";
          
            return View(articleList);
        }
        public ActionResult Authors()
        {
            var articleList = repoArticle.List();
            var authorList = articleList.GroupBy(u => new { u.Author }).Select(grp => grp.FirstOrDefault()).ToList();
            ViewBag.AuthorList = authorList.ToList();
            return View();
        }      
        public ActionResult Detail(string linkUrl)
        {
            if (linkUrl == null)
            {
                return RedirectToAction("","");
            }
            ViewBag.Title = "Makale | Detay Sayfasi";
            ArticleViewModel articleModel = (from article in repoArticle.List()
                                              join author in repoAuthor.List() on article.Author equals author.NameSurname
                                              where article.ArticleUrl == linkUrl
                                             select new ArticleViewModel
                                              {
                                                 //Article
                                                  ArticleUrl = article.ArticleUrl,
                                                  ArticleCategory = article.CategorName,
                                                  ArticleDate = article.ArticleDate,
                                                  Content = article.Content,
                                                  Title = article.Title,
                                                  ArticleReading = article.ReadingCount,
                                                  ArticleTags = article.Tags.Split(','),
                                                  // Author 
                                                  AuthorAbout = author.AuthorAbout,
                                                  AuthorFacebook = author.FacebookAdress,
                                                  AuthorImageUrl = author.Image,
                                                  AuthorInstagram = author.InstagramAdress,
                                                  AuthorName = author.NameSurname,
                                                  AuthorTwitter = author.TwitterAdress,
                                               
                                              }).FirstOrDefault();

            return View(articleModel);
        }
        public ActionResult TopArticle()
        {
            var articleList = repoArticle.List().OrderByDescending(m => m.ReadingCount).Take(3).ToList();
            return View(articleList);
        }
        public ActionResult InstagramArea()
        {
            return View();
        }
        public ActionResult Advertisement()
        {
            return View();
        }

        public ActionResult ImportantLink()
        {
            return View();
        }
        //Yapmak zorunda değilsiniz
        public ActionResult Create()
        {
            Article article = new Article()
            {
                ArticleDate = "10 Şubat 2018",
                Author = "Önceki Yazılımcı",
                ReadingCount = 50,
                CategorName = "Seyahat",
                Content = "Şanlıurfa'nın güneydoğusunda kalan Harran Ovası, günümüze taşıdığı tarihi değerleriyle bilgi veriyor ve coğrafyasıyla eşsiz bir güzellik sunuyor.",
                ImageUrl = "/Content/img/blog/2.jpg",
                IsActive = true,
                Tags = "Seyahat, Eğlence, Alışveriş, Yazılım, Hello World",
                ArticleUrl = "urfa'nin-sakli-cenneti-harran-ovasi",
                Title = "Seyahat Etmenin Faydaları"
            };
            repoArticle.Insert(article);
            repoArticle.Insert(article);
            repoArticle.Insert(article);

            return View();
        }


      
    }
}