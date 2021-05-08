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
    public class TournController : Controller
    {

        private Class1 db = new Class1();
        // GET: Tourn
        public ActionResult Index()
        {
            return View(db.TournTables.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "id,TName,TFormat,ADate,EDate,SDate,EnDate ,Rules,Fee")] TournTable TournTable)
        {


            // TODO:
            if (ModelState.IsValid)
            {
                db.TournTables.Add(TournTable);
                db.SaveChanges();
                return RedirectToAction("TournDetails");
            }
            return View(TournTable);
        }
    }
}







