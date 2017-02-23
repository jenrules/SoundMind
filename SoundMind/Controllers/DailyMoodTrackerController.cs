using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoundMind.Models;

namespace SoundMind.Controllers
{
    public class DailyMoodTrackerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DailyMoodTracker
        public ActionResult Index()
        {
            return View(db.DailyMoodTrackers.ToList());
        }

        // GET: DailyMoodTracker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMoodTracker dailyMoodTracker = db.DailyMoodTrackers.Find(id);
            if (dailyMoodTracker == null)
            {
                return HttpNotFound();
            }
            return View(dailyMoodTracker);
        }

        // GET: DailyMoodTracker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailyMoodTracker/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Mood,Notes")] DailyMoodTracker dailyMoodTracker)
        {
            if (ModelState.IsValid)
            {
                db.DailyMoodTrackers.Add(dailyMoodTracker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyMoodTracker);
        }

        // GET: DailyMoodTracker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMoodTracker dailyMoodTracker = db.DailyMoodTrackers.Find(id);
            if (dailyMoodTracker == null)
            {
                return HttpNotFound();
            }
            return View(dailyMoodTracker);
        }

        // POST: DailyMoodTracker/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Mood,Notes")] DailyMoodTracker dailyMoodTracker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyMoodTracker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyMoodTracker);
        }

        // GET: DailyMoodTracker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyMoodTracker dailyMoodTracker = db.DailyMoodTrackers.Find(id);
            if (dailyMoodTracker == null)
            {
                return HttpNotFound();
            }
            return View(dailyMoodTracker);
        }

        // POST: DailyMoodTracker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyMoodTracker dailyMoodTracker = db.DailyMoodTrackers.Find(id);
            db.DailyMoodTrackers.Remove(dailyMoodTracker);
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
