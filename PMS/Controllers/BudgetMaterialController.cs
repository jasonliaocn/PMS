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
    public class BudgetMaterialController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /BudgetMaterial/

        public ActionResult Index()
        {
            return View(db.BudgetMaterialModels.ToList());
        }

        //
        // GET: /BudgetMaterial/Details/5

        public ActionResult Details(int id = 0)
        {
            BudgetMaterialModels budgetmaterialmodels = db.BudgetMaterialModels.Find(id);
            if (budgetmaterialmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmaterialmodels);
        }

        //
        // GET: /BudgetMaterial/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BudgetMaterial/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BudgetMaterialModels budgetmaterialmodels)
        {
            if (ModelState.IsValid)
            {
                db.BudgetMaterialModels.Add(budgetmaterialmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(budgetmaterialmodels);
        }

        //
        // GET: /BudgetMaterial/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BudgetMaterialModels budgetmaterialmodels = db.BudgetMaterialModels.Find(id);
            if (budgetmaterialmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmaterialmodels);
        }

        //
        // POST: /BudgetMaterial/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BudgetMaterialModels budgetmaterialmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(budgetmaterialmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(budgetmaterialmodels);
        }

        //
        // GET: /BudgetMaterial/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BudgetMaterialModels budgetmaterialmodels = db.BudgetMaterialModels.Find(id);
            if (budgetmaterialmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmaterialmodels);
        }

        //
        // POST: /BudgetMaterial/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BudgetMaterialModels budgetmaterialmodels = db.BudgetMaterialModels.Find(id);
            db.BudgetMaterialModels.Remove(budgetmaterialmodels);
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