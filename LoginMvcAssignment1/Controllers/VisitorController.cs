using LoginMvcAssignment1.Models;
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
            
            Session["UserName"] = visitor.UserName;
    
            visitor.LoginTime = DateTime.Now;
            visitor.IpAddress = Request.UserHostAddress;
            db.Visitors.Add(visitor);
            db.SaveChanges();
            Session["UserID"] = visitor.LoginId;
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


           [HttpGet]     
        public ActionResult Index()
        {
            
            return View(db.Visitors);
        }

        [HttpPost]
        public ActionResult Index(Visitor visitor)
        {
           int id = Convert.ToInt32(Session["UserId"]);
           Visitor currentvisitor = db.Visitors.Single(v => v.LoginId == id);
             
              db.Visitors.Remove(currentvisitor);
            db.SaveChanges();

            return RedirectToAction("Login");

        }

    }
}