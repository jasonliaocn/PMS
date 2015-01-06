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
    public class EAController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /EA/

        public ActionResult Index()
        {
            return View(db.EaModels.ToList());
        }

        //
        // GET: /EA/Details/5

        public ActionResult Details(int id = 0)
        {
            EaModels eamodels = db.EaModels.Find(id);
            if (eamodels == null)
            {
                return HttpNotFound();
            }
            return View(eamodels);
        }

        //
        // GET: /EA/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EA/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EaModels eamodels)
        {
            if (ModelState.IsValid)
            {
                db.EaModels.Add(eamodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eamodels);
        }

        //
        // GET: /EA/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EaModels eamodels = db.EaModels.Find(id);
            if (eamodels == null)
            {
                return HttpNotFound();
            }
            return View(eamodels);
        }

        //
        // POST: /EA/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EaModels eamodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eamodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eamodels);
        }

        //
        // GET: /EA/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EaModels eamodels = db.EaModels.Find(id);
            if (eamodels == null)
            {
                return HttpNotFound();
            }
            return View(eamodels);
        }

        //
        // POST: /EA/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EaModels eamodels = db.EaModels.Find(id);
            db.EaModels.Remove(eamodels);
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