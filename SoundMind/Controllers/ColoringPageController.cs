using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SoundMind.Models;
using System.IO;

namespace SoundMind.Controllers
{
    public class ColoringPageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ColoringPage
        public ActionResult Index()
        {
            return View(db.ColoringPages.ToList());
        }

        // GET: ColoringPage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColoringPage coloringPage = db.ColoringPages.Find(id);
            if (coloringPage == null)
            {
                return HttpNotFound();
            }
            return View(coloringPage);
        }

        // GET: ColoringPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColoringPage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] ColoringPage coloringPage)
        {
            if (ModelState.IsValid)
            {
                db.ColoringPages.Add(coloringPage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coloringPage);
        }

        // GET: ColoringPage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColoringPage coloringPage = db.ColoringPages.Find(id);
            if (coloringPage == null)
            {
                return HttpNotFound();
            }
            return View(coloringPage);
        }
        // POST: ColoringPage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] ColoringPage coloringPage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coloringPage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coloringPage);
        }

        // GET: ColoringPage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColoringPage coloringPage = db.ColoringPages.Find(id);
            if (coloringPage == null)
            {
                return HttpNotFound();
            }
            return View(coloringPage);
        }

        // POST: ColoringPage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ColoringPage coloringPage = db.ColoringPages.Find(id);
            db.ColoringPages.Remove(coloringPage);
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
