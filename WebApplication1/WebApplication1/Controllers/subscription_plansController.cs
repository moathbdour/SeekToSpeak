using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class subscription_plansController : Controller
    {
        private SeekToSpeakEntities db = new SeekToSpeakEntities();

        // GET: subscription_plans
        public ActionResult Index()
        {
            return View(db.subscription_plans.ToList());
        }

        // GET: subscription_plans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subscription_plans subscription_plans = db.subscription_plans.Find(id);
            if (subscription_plans == null)
            {
                return HttpNotFound();
            }
            return View(subscription_plans);
        }

        // GET: subscription_plans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: subscription_plans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "plan_id,name,description,price,Available_Sessions")] subscription_plans subscription_plans)
        {
            if (ModelState.IsValid)
            {
                db.subscription_plans.Add(subscription_plans);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subscription_plans);
        }

        // GET: subscription_plans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subscription_plans subscription_plans = db.subscription_plans.Find(id);
            if (subscription_plans == null)
            {
                return HttpNotFound();
            }
            return View(subscription_plans);
        }

        // POST: subscription_plans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "plan_id,name,description,price,Available_Sessions")] subscription_plans subscription_plans)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subscription_plans).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscription_plans);
        }

        // GET: subscription_plans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subscription_plans subscription_plans = db.subscription_plans.Find(id);
            if (subscription_plans == null)
            {
                return HttpNotFound();
            }
            return View(subscription_plans);
        }

        // POST: subscription_plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subscription_plans subscription_plans = db.subscription_plans.Find(id);
            db.subscription_plans.Remove(subscription_plans);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
