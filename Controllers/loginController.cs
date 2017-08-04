using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectionApp3.Models;

namespace ElectionApp3.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        static List<sonal> sun = new List<sonal>();
        public ActionResult Index()
        {
            return View(sun);
        }
        public ActionResult Record(sonal sun)
        {
            return View(sun);
        }
        public ActionResult Login()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(sonal sonu)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", sonu);
            }
            sun.Add(sonu);
            return RedirectToAction("Index");
        }
    }
}