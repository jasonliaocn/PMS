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
    public class IitemController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Iitem/

        public ActionResult Index()
        {
            return View(db.IitemModels.ToList());
        }

        //
        // GET: /Iitem/Details/5

        public ActionResult Details(int id = 0)
        {
            IitemModels iitemmodels = db.IitemModels.Find(id);
            if (iitemmodels == null)
            {
                return HttpNotFound();
            }
            return View(iitemmodels);
        }

        //
        // GET: /Iitem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Iitem/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IitemModels iitemmodels)
        {
            if (ModelState.IsValid)
            {
                db.IitemModels.Add(iitemmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iitemmodels);
        }

        //
        // GET: /Iitem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IitemModels iitemmodels = db.IitemModels.Find(id);
            if (iitemmodels == null)
            {
                return HttpNotFound();
            }
            return View(iitemmodels);
        }

        //
        // POST: /Iitem/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IitemModels iitemmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iitemmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iitemmodels);
        }

        //
        // GET: /Iitem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IitemModels iitemmodels = db.IitemModels.Find(id);
            if (iitemmodels == null)
            {
                return HttpNotFound();
            }
            return View(iitemmodels);
        }

        //
        // POST: /Iitem/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IitemModels iitemmodels = db.IitemModels.Find(id);
            db.IitemModels.Remove(iitemmodels);
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