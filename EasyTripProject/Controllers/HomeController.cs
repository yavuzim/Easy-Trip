﻿using EasyTripProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripProject.Controllers
{
    public class HomeController : Controller
    {
        Context contextDb;
        public HomeController()
        {
            contextDb = new Context();
        }
        // GET: Home
        public ActionResult Index()
        {
            var items = contextDb.Blogs.Take(10).ToList();
            return View(items);
        }
        public PartialViewResult Partial()
        {
            var items = contextDb.Blogs.OrderByDescending(p=>p.BlogId).Take(2).ToList();
            return PartialView(items);
        }
        public PartialViewResult PartialRight()
        {
            var items = contextDb.Blogs.Where(p=>p.BlogId==3).ToList();
            return PartialView(items);
        }
        public PartialViewResult PartialBlogs()
        {
            var items = contextDb.Blogs.Take(10).ToList();
            return PartialView(items);
        }
        public PartialViewResult OurBestPlaces()
        {
            var items = contextDb.Blogs.Take(3).ToList();
            return PartialView(items);
        }
        public PartialViewResult OurBestPlacesRight()
        {
            var items = contextDb.Blogs.Take(3).OrderByDescending(p => p.BlogId).ToList();
            return PartialView(items);
        }
    }
}