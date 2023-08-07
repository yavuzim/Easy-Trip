using EasyTripProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripProject.Controllers
{
    public class AboutController : Controller
    {
        Context contextDb;
        public AboutController()
        {
            contextDb = new Context();
        }
        // GET: About
        public ActionResult Index()
        {
            var items = contextDb.Abouts.ToList();
            return View(items);
        }
    }
}