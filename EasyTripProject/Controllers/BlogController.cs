using EasyTripProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context contextDb;
        BlogComment blogComment;
        public BlogController()
        {
            contextDb = new Context();
            blogComment = new BlogComment();
        }
        // GET: Blog
        public ActionResult Index()
        {
            // var blogs = contextDb.Blogs.ToList();
            blogComment.Blog = contextDb.Blogs.ToList();
            blogComment.BlogFilter = contextDb.Blogs.Take(3).ToList();
            return View(blogComment);
        }
        public ActionResult BlogDetail(int id)
        {
            blogComment.Blog = contextDb.Blogs.Where(p => p.BlogId == id).ToList();
            blogComment.Comment = contextDb.Comments.Where(p => p.BlogId == id).ToList();
            return View(blogComment);
        }
        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.item = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MakeComment(Comments comments)
        {
            contextDb.Comments.Add(comments);
            contextDb.SaveChanges();
            return PartialView();
        }
    }
}