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
    public class MedAlarmController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MedAlarm
        public ActionResult Index()
        {
            return View(db.MedAlarms.ToList());
        }

        // GET: MedAlarm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedAlarm medAlarm = db.MedAlarms.Find(id);
            if (medAlarm == null)
            {
                return HttpNotFound();
            }
            return View(medAlarm);
        }

        // GET: MedAlarm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedAlarm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Time")] MedAlarm medAlarm)
        {
            if (ModelState.IsValid)
            {
                db.MedAlarms.Add(medAlarm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medAlarm);
        }

        // GET: MedAlarm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedAlarm medAlarm = db.MedAlarms.Find(id);
            if (medAlarm == null)
            {
                return HttpNotFound();
            }
            return View(medAlarm);
        }

        // POST: MedAlarm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Time")] MedAlarm medAlarm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medAlarm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medAlarm);
        }

        // GET: MedAlarm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedAlarm medAlarm = db.MedAlarms.Find(id);
            if (medAlarm == null)
            {
                return HttpNotFound();
            }
            return View(medAlarm);
        }

        // POST: MedAlarm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedAlarm medAlarm = db.MedAlarms.Find(id);
            db.MedAlarms.Remove(medAlarm);
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
