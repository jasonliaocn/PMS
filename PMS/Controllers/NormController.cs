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
    public class NormController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Norm/

        public ActionResult Index()
        {
            return View(db.NormModels.ToList());
        }

        //
        // GET: /Norm/Details/5

        public ActionResult Details(int id = 0)
        {
            NormModels normmodels = db.NormModels.Find(id);
            if (normmodels == null)
            {
                return HttpNotFound();
            }
            return View(normmodels);
        }

        //
        // GET: /Norm/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Norm/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NormModels normmodels)
        {
            if (ModelState.IsValid)
            {
                db.NormModels.Add(normmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(normmodels);
        }

        //
        // GET: /Norm/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NormModels normmodels = db.NormModels.Find(id);
            if (normmodels == null)
            {
                return HttpNotFound();
            }
            return View(normmodels);
        }

        //
        // POST: /Norm/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NormModels normmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(normmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(normmodels);
        }

        //
        // GET: /Norm/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NormModels normmodels = db.NormModels.Find(id);
            if (normmodels == null)
            {
                return HttpNotFound();
            }
            return View(normmodels);
        }

        //
        // POST: /Norm/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NormModels normmodels = db.NormModels.Find(id);
            db.NormModels.Remove(normmodels);
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