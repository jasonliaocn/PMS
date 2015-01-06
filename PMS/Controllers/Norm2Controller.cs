using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Models;

namespace PMS.Controllers
{
    public class Norm2Controller : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Norm2/

        public ActionResult Index()
        {
            return View(db.Norm2Models.ToList());
        }

        //
        // GET: /Norm2/Details/5

        public ActionResult Details(int id = 0)
        {
            Norm2Models norm2models = db.Norm2Models.Find(id);
            if (norm2models == null)
            {
                return HttpNotFound();
            }
            return View(norm2models);
        }

        //
        // GET: /Norm2/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Norm2/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Norm2Models norm2models)
        {
            if (ModelState.IsValid)
            {
                db.Norm2Models.Add(norm2models);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(norm2models);
        }

        //
        // GET: /Norm2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Norm2Models norm2models = db.Norm2Models.Find(id);
            if (norm2models == null)
            {
                return HttpNotFound();
            }
            return View(norm2models);
        }

        //
        // POST: /Norm2/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Norm2Models norm2models)
        {
            if (ModelState.IsValid)
            {
                db.Entry(norm2models).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(norm2models);
        }

        //
        // GET: /Norm2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Norm2Models norm2models = db.Norm2Models.Find(id);
            if (norm2models == null)
            {
                return HttpNotFound();
            }
            return View(norm2models);
        }

        //
        // POST: /Norm2/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Norm2Models norm2models = db.Norm2Models.Find(id);
            db.Norm2Models.Remove(norm2models);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}