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
    public class MaterialDTLController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /MaterialDTL/

        public ActionResult Index()
        {
            return View(db.MaterialDTLModels.ToList());
        }

        //
        // GET: /MaterialDTL/Details/5

        public ActionResult Details(int id = 0)
        {
            MaterialDTLModels materialdtlmodels = db.MaterialDTLModels.Find(id);
            if (materialdtlmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialdtlmodels);
        }

        //
        // GET: /MaterialDTL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MaterialDTL/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaterialDTLModels materialdtlmodels)
        {
            if (ModelState.IsValid)
            {
                db.MaterialDTLModels.Add(materialdtlmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materialdtlmodels);
        }

        //
        // GET: /MaterialDTL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MaterialDTLModels materialdtlmodels = db.MaterialDTLModels.Find(id);
            if (materialdtlmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialdtlmodels);
        }

        //
        // POST: /MaterialDTL/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MaterialDTLModels materialdtlmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materialdtlmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materialdtlmodels);
        }

        //
        // GET: /MaterialDTL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MaterialDTLModels materialdtlmodels = db.MaterialDTLModels.Find(id);
            if (materialdtlmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialdtlmodels);
        }

        //
        // POST: /MaterialDTL/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaterialDTLModels materialdtlmodels = db.MaterialDTLModels.Find(id);
            db.MaterialDTLModels.Remove(materialdtlmodels);
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