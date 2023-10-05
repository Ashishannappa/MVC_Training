using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetMvc.Models;

namespace DotNetMvc.Controllers
{
    [RoutePrefix("Ashish")]
    public class HotelController : Controller
    {
        private HotelEntities db = new HotelEntities();

        // GET: Hotel
        [Route("Get")]
        public ActionResult Index()
        {
            return View(db.HotelSystems.ToList());
        }

        // GET: Hotel/Details/5
        [Route("Details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelSystem hotelSystem = db.HotelSystems.Find(id);
            if (hotelSystem == null)
            {
                return HttpNotFound();
            }
            return View(hotelSystem);
        }

        // GET: Hotel/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,PhoneNumber,Adress")] HotelSystem hotelSystem)
        {
            if (ModelState.IsValid)
            {
                db.HotelSystems.Add(hotelSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotelSystem);
        }

        // GET: Hotel/Edit/5
        [Route("Edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelSystem hotelSystem = db.HotelSystems.Find(id);
            if (hotelSystem == null)
            {
                return HttpNotFound();
            }
            return View(hotelSystem);
        }

        // POST: Hotel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,PhoneNumber,Adress")] HotelSystem hotelSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotelSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotelSystem);
        }

        // GET: Hotel/Delete/5
        [Route("Delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelSystem hotelSystem = db.HotelSystems.Find(id);
            if (hotelSystem == null)
            {
                return HttpNotFound();
            }
            return View(hotelSystem);
        }

        // POST: Hotel/Delete/5
        [Route("Delete/{id}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HotelSystem hotelSystem = db.HotelSystems.Find(id);
            db.HotelSystems.Remove(hotelSystem);
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
