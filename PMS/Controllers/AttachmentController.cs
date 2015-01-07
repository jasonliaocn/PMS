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
    public class AttachmentController : Controller
    {
        private PMSDBContext db = new PMSDBContext();

        //
        // GET: /Attachment/

        public ActionResult Index()
        {
            return View(db.AttachmentModels.ToList());
        }

        //
        // GET: /Attachment/Details/5

        public ActionResult Details(int id = 0)
        {
            AttachmentModels attachmentmodels = db.AttachmentModels.Find(id);
            if (attachmentmodels == null)
            {
                return HttpNotFound();
            }
            return View(attachmentmodels);
        }

        //
        // GET: /Attachment/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Attachment/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AttachmentModels attachmentmodels)
        {
            if (ModelState.IsValid)
            {
                db.AttachmentModels.Add(attachmentmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attachmentmodels);
        }

        //
        // GET: /Attachment/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AttachmentModels attachmentmodels = db.AttachmentModels.Find(id);
            if (attachmentmodels == null)
            {
                return HttpNotFound();
            }
            return View(attachmentmodels);
        }

        //
        // POST: /Attachment/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AttachmentModels attachmentmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attachmentmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attachmentmodels);
        }

        //
        // GET: /Attachment/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AttachmentModels attachmentmodels = db.AttachmentModels.Find(id);
            if (attachmentmodels == null)
            {
                return HttpNotFound();
            }
            return View(attachmentmodels);
        }

        //
        // POST: /Attachment/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttachmentModels attachmentmodels = db.AttachmentModels.Find(id);
            db.AttachmentModels.Remove(attachmentmodels);
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