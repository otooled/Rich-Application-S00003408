﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA2.Controllers
{
    public class HomeController : Controller
    {
        private northwndEntities db = new northwndEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Shipper);
            return View(orders.ToList());
        }

        //
        // GET: /Home/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(order);
        //}

        //
        // GET: /Home/Create

        //public ActionResult Create()
        //{
        //    ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName");
        //    ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName");
        //    ViewBag.ShipVia = new SelectList(db.Shippers, "ShipperID", "CompanyName");
        //    return View();
        //}

        ////
        //// POST: /Home/Create

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Orders.Add(order);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", order.CustomerID);
        //    ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", order.EmployeeID);
        //    ViewBag.ShipVia = new SelectList(db.Shippers, "ShipperID", "CompanyName", order.ShipVia);
        //    return View(order);
        //}

        ////
        //// GET: /Home/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", order.CustomerID);
        //    ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", order.EmployeeID);
        //    ViewBag.ShipVia = new SelectList(db.Shippers, "ShipperID", "CompanyName", order.ShipVia);
        //    return View(order);
        //}

        ////
        //// POST: /Home/Edit/5

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(order).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", order.CustomerID);
        //    ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "LastName", order.EmployeeID);
        //    ViewBag.ShipVia = new SelectList(db.Shippers, "ShipperID", "CompanyName", order.ShipVia);
        //    return View(order);
        //}

        ////
        //// GET: /Home/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(order);
        //}

        ////
        //// POST: /Home/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Order order = db.Orders.Find(id);
        //    db.Orders.Remove(order);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}