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
    public class TemplateController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Template/

        public ActionResult Index()
        {
            return View(db.TemplateModels.ToList());
        }

        //
        // GET: /Template/Details/5

        public ActionResult Details(int id = 0)
        {
            TemplateModels templatemodels = db.TemplateModels.Find(id);
            if (templatemodels == null)
            {
                return HttpNotFound();
            }
            return View(templatemodels);
        }

        //
        // GET: /Template/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Template/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TemplateModels templatemodels)
        {
            if (ModelState.IsValid)
            {
                db.TemplateModels.Add(templatemodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(templatemodels);
        }

        //
        // GET: /Template/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TemplateModels templatemodels = db.TemplateModels.Find(id);
            if (templatemodels == null)
            {
                return HttpNotFound();
            }
            return View(templatemodels);
        }

        //
        // POST: /Template/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TemplateModels templatemodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(templatemodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(templatemodels);
        }

        //
        // GET: /Template/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TemplateModels templatemodels = db.TemplateModels.Find(id);
            if (templatemodels == null)
            {
                return HttpNotFound();
            }
            return View(templatemodels);
        }

        //
        // POST: /Template/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TemplateModels templatemodels = db.TemplateModels.Find(id);
            db.TemplateModels.Remove(templatemodels);
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