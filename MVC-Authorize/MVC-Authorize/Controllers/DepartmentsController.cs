using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Authorize.Models.Entity;

namespace MVC_Authorize.Controllers
{
    public class DepartmentsController : Controller
    {
        private devrimme_ramazanBeyDbEntities db = new devrimme_ramazanBeyDbEntities();

        // GET: Departments
        public ActionResult Index()
        {
            return View(db.Tbl_Department.ToList());
        }

        // GET: Departments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Department tbl_Department = db.Tbl_Department.Find(id);
            if (tbl_Department == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Department);
        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DepartmentName")] Tbl_Department tbl_Department)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Department.Add(tbl_Department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Department);
        }

        // GET: Departments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Department tbl_Department = db.Tbl_Department.Find(id);
            if (tbl_Department == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Department);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DepartmentName")] Tbl_Department tbl_Department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Department).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Department);
        }

        // GET: Departments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Department tbl_Department = db.Tbl_Department.Find(id);
            if (tbl_Department == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Department tbl_Department = db.Tbl_Department.Find(id);
            db.Tbl_Department.Remove(tbl_Department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
