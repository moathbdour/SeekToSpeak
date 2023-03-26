using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentProfileController : Controller
    {
        // GET: StudentProfile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Reviews()
        {
            return View();
        }
        public ActionResult My_sessions()
        {
            return View();
        }
        public ActionResult settings()
        {
            return View();
        }
        public ActionResult subscriptions()
        {
            return View();
        }
    }
}