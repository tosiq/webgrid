using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        imtiazEntities db = new imtiazEntities();
       static List<login> db1 = new List<login>();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(login o)
        {
            db.logins.Add(o);
            db.SaveChanges();
            db1.Add(o);
            ModelState.Clear();

            return RedirectToAction("form","Home");
        }

        public ActionResult form()
        {
            return View(db1.ToList());
        }


    }
}