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
    public class UnitController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Unit/

        public ActionResult Index()
        {
            return View(db.UnitModels.ToList());
        }

        //
        // GET: /Unit/Details/5

        public ActionResult Details(int id = 0)
        {
            UnitModels unitmodels = db.UnitModels.Find(id);
            if (unitmodels == null)
            {
                return HttpNotFound();
            }
            return View(unitmodels);
        }

        //
        // GET: /Unit/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Unit/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnitModels unitmodels)
        {
            if (ModelState.IsValid)
            {
                db.UnitModels.Add(unitmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unitmodels);
        }

        //
        // GET: /Unit/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UnitModels unitmodels = db.UnitModels.Find(id);
            if (unitmodels == null)
            {
                return HttpNotFound();
            }
            return View(unitmodels);
        }

        //
        // POST: /Unit/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnitModels unitmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unitmodels);
        }

        //
        // GET: /Unit/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UnitModels unitmodels = db.UnitModels.Find(id);
            if (unitmodels == null)
            {
                return HttpNotFound();
            }
            return View(unitmodels);
        }

        //
        // POST: /Unit/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnitModels unitmodels = db.UnitModels.Find(id);
            db.UnitModels.Remove(unitmodels);
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