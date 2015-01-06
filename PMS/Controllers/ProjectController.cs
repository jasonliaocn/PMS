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
    public class ProjectController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Project/

        public ActionResult Index()
        {
            return View(db.ProjectModels.ToList());
        }

        //
        // GET: /Project/Details/5

        public ActionResult Details(int id = 0)
        {
            ProjectModels projectmodels = db.ProjectModels.Find(id);
            if (projectmodels == null)
            {
                return HttpNotFound();
            }
            return View(projectmodels);
        }

        //
        // GET: /Project/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Project/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectModels projectmodels)
        {
            if (ModelState.IsValid)
            {
                db.ProjectModels.Add(projectmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectmodels);
        }

        //
        // GET: /Project/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ProjectModels projectmodels = db.ProjectModels.Find(id);
            if (projectmodels == null)
            {
                return HttpNotFound();
            }
            return View(projectmodels);
        }

        //
        // POST: /Project/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectModels projectmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectmodels);
        }

        //
        // GET: /Project/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ProjectModels projectmodels = db.ProjectModels.Find(id);
            if (projectmodels == null)
            {
                return HttpNotFound();
            }
            return View(projectmodels);
        }

        //
        // POST: /Project/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectModels projectmodels = db.ProjectModels.Find(id);
            db.ProjectModels.Remove(projectmodels);
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