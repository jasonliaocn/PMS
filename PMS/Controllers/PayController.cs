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
    public class PayController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Pay/

        public ActionResult Index()
        {
            return View(db.PayModels.ToList());
        }

        //
        // GET: /Pay/Details/5

        public ActionResult Details(int id = 0)
        {
            PayModels paymodels = db.PayModels.Find(id);
            if (paymodels == null)
            {
                return HttpNotFound();
            }
            return View(paymodels);
        }

        //
        // GET: /Pay/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pay/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PayModels paymodels)
        {
            if (ModelState.IsValid)
            {
                db.PayModels.Add(paymodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymodels);
        }

        //
        // GET: /Pay/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PayModels paymodels = db.PayModels.Find(id);
            if (paymodels == null)
            {
                return HttpNotFound();
            }
            return View(paymodels);
        }

        //
        // POST: /Pay/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PayModels paymodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymodels);
        }

        //
        // GET: /Pay/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PayModels paymodels = db.PayModels.Find(id);
            if (paymodels == null)
            {
                return HttpNotFound();
            }
            return View(paymodels);
        }

        //
        // POST: /Pay/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayModels paymodels = db.PayModels.Find(id);
            db.PayModels.Remove(paymodels);
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