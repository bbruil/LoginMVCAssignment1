﻿using LoginMvcAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMvcAssignment1.Controllers
{
    public class VisitorController : Controller
    {
        private MyDBContext db = new MyDBContext();

        [HttpPost]
        public ActionResult Login(Visitor visitor)
        {

            db.Visitors.Add(visitor);
            db.SaveChanges();
            return View("Index");

        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpGet]
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Visitors);
        }

    }
}