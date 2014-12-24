using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRSuite.DAL;
using HRSuite.Models;

namespace HRSuite.Controllers
{
    public class EmployeeInfoController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: EmployeeInfo
        public ActionResult Index()
        {
            return View(db.EmployeeInfo.ToList());
        }

        // GET: EmployeeInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfo employeeInfo = db.EmployeeInfo.Find(id);
            if (employeeInfo == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfo);
        }

        // GET: EmployeeInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeInfoID,FirstName,MiddleName,LastName,DOB,Gender,PhoneNumber,Address,SSN")] EmployeeInfo employeeInfo)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeInfo.Add(employeeInfo);
                Employee employee = new Employee();
                employee.EmployeeInfoID = employeeInfo.EmployeeInfoID;
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeInfo);
        }

        // GET: EmployeeInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfo employeeInfo = db.EmployeeInfo.Find(id);
            if (employeeInfo == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfo);
        }

        // POST: EmployeeInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeInfoID,FirstName,MiddleName,LastName,DOB,Gender,PhoneNumber,Address,SSN")] EmployeeInfo employeeInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeInfo);
        }

        // GET: EmployeeInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeInfo employeeInfo = db.EmployeeInfo.Find(id);
            if (employeeInfo == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfo);
        }

        // POST: EmployeeInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeInfo employeeInfo = db.EmployeeInfo.Find(id);
            db.EmployeeInfo.Remove(employeeInfo);
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
