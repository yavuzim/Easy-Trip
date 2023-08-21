using EasyTripProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context context;
        public AdminController()
        {
            context = new Context();
        }
        // GET: Admin
        public ActionResult Index()
        {
            var items = context.Blogs.ToList();
            return View(items);
        }
        [HttpGet] // sayfa yüklenince hiçbir şey yapma.NewBlog() metodundaki işlemleri yap.
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost] // sayfada post işlemi yaptığım zaman NewBlog(Blog blog) metodundaki işlemleri yap.
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDelete(int BlogId)
        {
            var blog = context.Blogs.Find(BlogId);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int blogId)
        {
            var blog = context.Blogs.Find(blogId);
            return View("GetBlog", blog);
        }
        public ActionResult BlogUpdate(Blog blog)
        {
            var getBlog = context.Blogs.Find(blog.BlogId);
            getBlog.Description = blog.Description;
            getBlog.Title = blog.Title;
            getBlog.Date = blog.Date;
            blog.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }
        public ActionResult RemoveComment(int commentId)
        {
            var comment = context.Comments.Find(commentId);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult GetComment(int commentId)
        {
            var comment = context.Comments.Find(commentId);
            return View("GetComment", comment);
        }
        public ActionResult CommentUpdate(Comments comment)
        {
            var getComment = context.Comments.Find(comment.CommentId);
            getComment.UserName = comment.UserName;
            getComment.Email = comment.Email;
            getComment.Comment = comment.Comment;
            context.SaveChanges();

            return RedirectToAction("CommentList");
        }
    }
}