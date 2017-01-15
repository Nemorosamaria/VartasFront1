using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VartasBackend1.Models;

namespace VartasBackend1.Controllers
{
    public class TuotesController : Controller
    {
        private TuoteDBContext db = new TuoteDBContext();

        // GET: Tuotes
        public ActionResult Index(string searchString)
        {
            var tuotes = from m in db.Tuotteet
                         select m;
            // filter products by Name
            if (!String.IsNullOrEmpty(searchString))
            {
                tuotes = tuotes.Where(s => s.Name.Contains(searchString));
            }
            return View(tuotes);
        }

        // GET: Tuotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // GET: Tuotes/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: Tuotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TuoteId,Name,ProductKey,Manufacturer,Category,Price,IsStorageProduct,IsPrSaldoPositive,Saldo,Description,Edited,Editor")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Tuotteet.Add(tuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuote);
        }

        // GET: Tuotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TuoteId,Name,ProductKey,Manufacturer,Category,Price,IsStorageProduct,IsPrSaldoPositive,Saldo,Description,Edited,Editor")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuote);
        }

        // GET: Tuotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuotteet.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tuote tuote = db.Tuotteet.Find(id);
            db.Tuotteet.Remove(tuote);
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
