using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddres,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate the quote
                insuree.Quote = CalculateQuote(insuree);

                // Save the insuree in the database
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList(); // Get all insurees
            return View(insurees); // Pass the list of insurees to the Admin view
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal baseRate = 50.00M;
            decimal quote = baseRate;

            // Age calculation
            if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 18)
            {
                quote += 100; // Add $100 for ages 18 or under
            }
            else if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 25)
            {
                quote += 50; // Add $50 for ages 19 to 25
            }
            else
            {
                quote += 25; // Add $25 for ages 26 or older
            }

            // Car year calculation
            if (insuree.CarYear < 2000)
            {
                quote += 25; // Add $25 for cars before 2000
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25; // Add $25 for cars after 2015
            }

            // Car make and model calculation
            if (insuree.CarMake == "Porsche")
            {
                quote += 25; // Add $25 for Porsche
                if (insuree.CarModel == "911 Carrera")
                {
                    quote += 25; // Add an additional $25 for Porsche 911 Carrera
                }
            }

            // Speeding tickets calculation
            quote += insuree.SpeedingTickets * 10; // Add $10 per speeding ticket

            // DUI calculation
            if (insuree.DUI)
            {
                quote *= 1.25M; // Add 25% if the user has a DUI
            }

            // Coverage type calculation
            if (insuree.CoverageType)
            {
                quote *= 1.50M; // Add 50% for full coverage
            }

            return quote;
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddres,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
