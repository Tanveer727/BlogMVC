using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {
        BlogEntities blogEntities = new BlogEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = blogEntities.Blogs.ToList().OrderByDescending(x=>x.Bid);
            return View(blogdetails);
        }


        public ActionResult UploadBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadBlog(Blog bg)
        {           
            blogEntities.Blogs.Add(bg);
            blogEntities.SaveChanges();
            ViewBag.message = "Blog Details Are saved Successfully..!";
            return View();
        }


        public ActionResult Food()
        {
            var Foodarticle = blogEntities.Blogs.Where(x=>x.BCategory == "Food").OrderByDescending(x => x.Bid);
            return View(Foodarticle);

        }


        public ActionResult Sports()
        {
            var Sportsarticle = blogEntities.Blogs.Where(x => x.BCategory == "Sports").OrderByDescending(x => x.Bid);
            return View(Sportsarticle);

        }


        public ActionResult Movies()
        {
            var Sportsarticle = blogEntities.Blogs.Where(x => x.BCategory == "Movies").OrderByDescending(x => x.Bid);
            return View(Sportsarticle);

        }

        public ActionResult Recipesworld()
        {
            return View();
        }

        public ActionResult HindiMovies()
        {
            return View();
        }

        public ActionResult CricketTips()
        {
            return View();
                 
        }
        
      
    }
}