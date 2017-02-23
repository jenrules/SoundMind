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
    public class RelaxController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Relax
        public ActionResult Index()
        {
            return View(db.Relaxes.ToList());
        }

        // GET: Relax/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relax relax = db.Relaxes.Find(id);
            if (relax == null)
            {
                return HttpNotFound();
            }
            return View(relax);
        }

        // GET: Relax/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relax/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Technique")] Relax relax)
        {
            if (ModelState.IsValid)
            {
                db.Relaxes.Add(relax);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relax);
        }

        // GET: Relax/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relax relax = db.Relaxes.Find(id);
            if (relax == null)
            {
                return HttpNotFound();
            }
            return View(relax);
        }

        // POST: Relax/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Technique")] Relax relax)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relax).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relax);
        }

        // GET: Relax/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relax relax = db.Relaxes.Find(id);
            if (relax == null)
            {
                return HttpNotFound();
            }
            return View(relax);
        }

        // POST: Relax/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Relax relax = db.Relaxes.Find(id);
            db.Relaxes.Remove(relax);
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
