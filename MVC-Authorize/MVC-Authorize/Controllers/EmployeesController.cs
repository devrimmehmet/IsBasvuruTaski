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
    public class EmployeesController : Controller
    {
        private devrimme_ramazanBeyDbEntities db = new devrimme_ramazanBeyDbEntities();

        // GET: Employees
        public ActionResult Index()
        {
            var tbl_Employee = db.Tbl_Employee.Include(t => t.Tbl_Department);
            return View(tbl_Employee.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Employee tbl_Employee = db.Tbl_Employee.Find(id);
            if (tbl_Employee == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.Department_Id = new SelectList(db.Tbl_Department, "Id", "DepartmentName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Department_Id,Name,Surname,DateOfBirth,Gender,IsMarried")] Tbl_Employee tbl_Employee)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Employee.Add(tbl_Employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Department_Id = new SelectList(db.Tbl_Department, "Id", "DepartmentName", tbl_Employee.Department_Id);
            return View(tbl_Employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Employee tbl_Employee = db.Tbl_Employee.Find(id);
            if (tbl_Employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.Department_Id = new SelectList(db.Tbl_Department, "Id", "DepartmentName", tbl_Employee.Department_Id);
            return View(tbl_Employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Department_Id,Name,Surname,DateOfBirth,Gender,IsMarried")] Tbl_Employee tbl_Employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Department_Id = new SelectList(db.Tbl_Department, "Id", "DepartmentName", tbl_Employee.Department_Id);
            return View(tbl_Employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Employee tbl_Employee = db.Tbl_Employee.Find(id);
            if (tbl_Employee == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Employee tbl_Employee = db.Tbl_Employee.Find(id);
            db.Tbl_Employee.Remove(tbl_Employee);
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
