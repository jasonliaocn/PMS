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
    public class EAinfoController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /EAinfo/

        public ActionResult Index()
        {
            return View(db.EAinfoModels.ToList());
        }

        //
        // GET: /EAinfo/Details/5

        public ActionResult Details(int id = 0)
        {
            EAinfoModels eainfomodels = db.EAinfoModels.Find(id);
            if (eainfomodels == null)
            {
                return HttpNotFound();
            }
            return View(eainfomodels);
        }

        //
        // GET: /EAinfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EAinfo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EAinfoModels eainfomodels)
        {
            if (ModelState.IsValid)
            {
                db.EAinfoModels.Add(eainfomodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eainfomodels);
        }

        //
        // GET: /EAinfo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EAinfoModels eainfomodels = db.EAinfoModels.Find(id);
            if (eainfomodels == null)
            {
                return HttpNotFound();
            }
            return View(eainfomodels);
        }

        //
        // POST: /EAinfo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EAinfoModels eainfomodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eainfomodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eainfomodels);
        }

        //
        // GET: /EAinfo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EAinfoModels eainfomodels = db.EAinfoModels.Find(id);
            if (eainfomodels == null)
            {
                return HttpNotFound();
            }
            return View(eainfomodels);
        }

        //
        // POST: /EAinfo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EAinfoModels eainfomodels = db.EAinfoModels.Find(id);
            db.EAinfoModels.Remove(eainfomodels);
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