using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mapa.Models;

namespace mapa.Controllers
{
    public class m1Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: m1
        public ActionResult Index()
        {
            return View(db.m1.ToList());
        }

        // GET: m1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            m1 m1 = db.m1.Find(id);
            if (m1 == null)
            {
                return HttpNotFound();
            }
            return View(m1);
        }

        // GET: m1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: m1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "m1Id,nazwa,adres")] m1 m1)
        {
            if (ModelState.IsValid)
            {
                db.m1.Add(m1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(m1);
        }

        // GET: m1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            m1 m1 = db.m1.Find(id);
            if (m1 == null)
            {
                return HttpNotFound();
            }
            return View(m1);
        }

        // POST: m1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "m1Id,nazwa,adres")] m1 m1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(m1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m1);
        }

        // GET: m1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            m1 m1 = db.m1.Find(id);
            if (m1 == null)
            {
                return HttpNotFound();
            }
            return View(m1);
        }

        // POST: m1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            m1 m1 = db.m1.Find(id);
            db.m1.Remove(m1);
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
