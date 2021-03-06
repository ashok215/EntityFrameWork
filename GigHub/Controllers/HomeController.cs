﻿using GigHub.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var gigs = _context.Gigs.Include(m => m.Artist).Include(m => m.Genre).Where(m => m.DateTime > DateTime.Now);
            return View(gigs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}