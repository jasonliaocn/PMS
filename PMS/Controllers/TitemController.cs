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
    public class TitemController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Titem/

        public ActionResult Index()
        {
            return View(db.TitemModels.ToList());
        }

        //
        // GET: /Titem/Details/5

        public ActionResult Details(int id = 0)
        {
            TitemModels titemmodels = db.TitemModels.Find(id);
            if (titemmodels == null)
            {
                return HttpNotFound();
            }
            return View(titemmodels);
        }

        //
        // GET: /Titem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Titem/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TitemModels titemmodels)
        {
            if (ModelState.IsValid)
            {
                db.TitemModels.Add(titemmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titemmodels);
        }

        //
        // GET: /Titem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TitemModels titemmodels = db.TitemModels.Find(id);
            if (titemmodels == null)
            {
                return HttpNotFound();
            }
            return View(titemmodels);
        }

        //
        // POST: /Titem/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TitemModels titemmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titemmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titemmodels);
        }

        //
        // GET: /Titem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TitemModels titemmodels = db.TitemModels.Find(id);
            if (titemmodels == null)
            {
                return HttpNotFound();
            }
            return View(titemmodels);
        }

        //
        // POST: /Titem/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TitemModels titemmodels = db.TitemModels.Find(id);
            db.TitemModels.Remove(titemmodels);
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