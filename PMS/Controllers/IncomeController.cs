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
    public class IncomeController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Income/

        public ActionResult Index()
        {
            return View(db.IncomeModels.ToList());
        }

        //
        // GET: /Income/Details/5

        public ActionResult Details(int id = 0)
        {
            IncomeModels incomemodels = db.IncomeModels.Find(id);
            if (incomemodels == null)
            {
                return HttpNotFound();
            }
            return View(incomemodels);
        }

        //
        // GET: /Income/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Income/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IncomeModels incomemodels)
        {
            if (ModelState.IsValid)
            {
                db.IncomeModels.Add(incomemodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incomemodels);
        }

        //
        // GET: /Income/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IncomeModels incomemodels = db.IncomeModels.Find(id);
            if (incomemodels == null)
            {
                return HttpNotFound();
            }
            return View(incomemodels);
        }

        //
        // POST: /Income/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IncomeModels incomemodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomemodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incomemodels);
        }

        //
        // GET: /Income/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IncomeModels incomemodels = db.IncomeModels.Find(id);
            if (incomemodels == null)
            {
                return HttpNotFound();
            }
            return View(incomemodels);
        }

        //
        // POST: /Income/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeModels incomemodels = db.IncomeModels.Find(id);
            db.IncomeModels.Remove(incomemodels);
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