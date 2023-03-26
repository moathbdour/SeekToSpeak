using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult statistics()
        {
            return View();
        }
        public ActionResult Speakers()
        {
            return View();
        }
        public ActionResult sub_Plans()
        {
            return View();
        }
        public ActionResult settings()
        {
            return View();
        }
       
    }
}