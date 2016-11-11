using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RTO.Models;
using MvpRestApiLib;

namespace RTO.Controllers
{
    public class RTOController : Controller
    {
        private RTOContext db = new RTOContext();

        //
        [EnableJson]
        public ActionResult Index(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return View(db.RegDetails.ToList());
            else
                return View(db.RegDetails.Where(r => r.RegNumber.Contains(keyword)
                || r.VehicleName.Contains(keyword) || r.VehicleMake.Contains(keyword)).ToList());
        }

        
        //
        // GET: /RTO/Details/5

        public ActionResult Details(int id = 0)
        {
            RegDetail regdetail = db.RegDetails.Single(r => r.Id == id);
            if (regdetail == null)
            {
                return HttpNotFound();
            }
            return View(regdetail);
        }

        //
        // GET: /RTO/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RTO/Create
        [EnableJson]
        [HttpPost]
        public ActionResult Create(RegDetail regdetail)
        {
            if (ModelState.IsValid)
            {
                db.RegDetails.AddObject(regdetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regdetail);
        }

        //
        // GET: /RTO/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RegDetail regdetail = db.RegDetails.Single(r => r.Id == id);
            if (regdetail == null)
            {
                return HttpNotFound();
            }
            return View(regdetail);
        }

        //
        // POST: /RTO/Edit/5

        [HttpPost]
        public ActionResult Edit(RegDetail regdetail)
        {
            if (ModelState.IsValid)
            {
                db.RegDetails.Attach(regdetail);
                db.ObjectStateManager.ChangeObjectState(regdetail, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regdetail);
        }

        //
        // GET: /RTO/Delete/5
        [HttpDelete]
        public int Delete(int id = 0)
        {
            RegDetail regdetail = db.RegDetails.Single(r => r.Id == id);
            if (regdetail != null)
            {
                db.RegDetails.DeleteObject(regdetail);
                db.SaveChanges();
            }
            return id;
        }

        //
        // POST: /RTO/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RegDetail regdetail = db.RegDetails.Single(r => r.Id == id);
            db.RegDetails.DeleteObject(regdetail);
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