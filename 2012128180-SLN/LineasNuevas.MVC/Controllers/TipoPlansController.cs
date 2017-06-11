using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012128180_EN.Entities;
using _2012128180_PER.Persistence;

namespace LineasNuevas.MVC.Controllers
{
    public class TipoPlansController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: TipoPlans
        public ActionResult Index()
        {
            return View(db.TipoPlan.ToList());
        }

        // GET: TipoPlans/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(Id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // GET: TipoPlans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoPlans/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoPlanId")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                db.TipoPlan.Add(tipoPlan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPlan);
        }

        // GET: TipoPlans/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(Id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: TipoPlans/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoPlanId")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoPlan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoPlan);
        }

        // GET: TipoPlans/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPlan tipoPlan = db.TipoPlan.Find(Id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: TipoPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            TipoPlan tipoPlan = db.TipoPlan.Find(Id);
            db.TipoPlan.Remove(tipoPlan);
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
