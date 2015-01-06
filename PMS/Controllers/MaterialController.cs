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
    public class MaterialController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Material/

        public ActionResult Index()
        {
            return View(db.MaterialModels.ToList());
        }

        //
        // GET: /Material/Details/5

        public ActionResult Details(int id = 0)
        {
            MaterialModels materialmodels = db.MaterialModels.Find(id);
            if (materialmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialmodels);
        }

        //
        // GET: /Material/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Material/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaterialModels materialmodels)
        {
            if (ModelState.IsValid)
            {
                db.MaterialModels.Add(materialmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materialmodels);
        }

        //
        // GET: /Material/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MaterialModels materialmodels = db.MaterialModels.Find(id);
            if (materialmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialmodels);
        }

        //
        // POST: /Material/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MaterialModels materialmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materialmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materialmodels);
        }

        //
        // GET: /Material/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MaterialModels materialmodels = db.MaterialModels.Find(id);
            if (materialmodels == null)
            {
                return HttpNotFound();
            }
            return View(materialmodels);
        }

        //
        // POST: /Material/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaterialModels materialmodels = db.MaterialModels.Find(id);
            db.MaterialModels.Remove(materialmodels);
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