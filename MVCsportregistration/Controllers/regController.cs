using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using MVCsportregistration.Models;


namespace MVCsportregistration.Controllers
{
    public class regController : Controller
    {

        private Model1 db = new Model1();
        // GET: reg
        public ActionResult Index()
        {
            return View(db.sportTables.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "Id,Name,Idnum,IdType,Email,Mobile,Address ,Pin,Sport,Role,Password")] sportTable sportTable)
        {


            // TODO:
            if (ModelState.IsValid)
            {
                db.sportTables.Add(sportTable);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(sportTable);
        }
        public ActionResult Register()
        {
            var list = new List<string>() { "Adar No", "Voter Id", "Passport No", "DL No" };
            ViewBag.list = list;
            return View();
        }
        
           public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(sportTable user)
        {
            var verifi = db.sportTables.Where(a => a.Email.Equals(user.Email) && a.Password.Equals(user.Password)).SingleOrDefault();
            if (verifi != null)
            {


                Session["User"] = user.Email;
                return RedirectToAction("Details");
            }
            else
            {
                ViewBag.error = "Wrong Password or Email";
                return View();
            }
        }


        public ActionResult Dashboard()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {

                return RedirectToAction("Details");

            }
        }



        public ActionResult Details()
        {
            var user = User.Identity.Name;

            var result = db.sportTables.Where(x => x.Email == user).FirstOrDefault();
            return View(result);
        }
        public ActionResult User_Dashboard()
        {
            return View();
        }
        


        





























    }
}









