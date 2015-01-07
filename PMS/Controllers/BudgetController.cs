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
    public class BudgetController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Budget/

        public ActionResult Index()
        {
            return View(db.BudgetModels.ToList());
        }

        //
        // GET: /Budget/Details/5

        public ActionResult Details(int id = 0)
        {
            BudgetModels budgetmodels = db.BudgetModels.Find(id);
            if (budgetmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmodels);
        }

        //
        // GET: /Budget/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Budget/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BudgetModels budgetmodels)
        {
            if (ModelState.IsValid)
            {
                db.BudgetModels.Add(budgetmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(budgetmodels);
        }

        //
        // GET: /Budget/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BudgetModels budgetmodels = db.BudgetModels.Find(id);
            if (budgetmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmodels);
        }

        //
        // POST: /Budget/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BudgetModels budgetmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(budgetmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(budgetmodels);
        }

        //
        // GET: /Budget/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BudgetModels budgetmodels = db.BudgetModels.Find(id);
            if (budgetmodels == null)
            {
                return HttpNotFound();
            }
            return View(budgetmodels);
        }

        //
        // POST: /Budget/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BudgetModels budgetmodels = db.BudgetModels.Find(id);
            db.BudgetModels.Remove(budgetmodels);
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