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
    public class VentasController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: Ventas
        public ActionResult Index()
        {
            var Ventas = db.Ventas.Include(v => v.CentroAtencion);
            return View(Ventas.ToList());
        }

        // GET: Ventas/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ventas Ventas = db.Ventas.Find(Id);
            if (Ventas == null)
            {
                return HttpNotFound();
            }
            return View(Ventas);
        }

        // GET: Ventas/Create
        public ActionResult Create()
        {
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId");
            return View();
        }

        // POST: Ventas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VentasId,CentroAtencionId")] Ventas Ventas)
        {
            if (ModelState.IsValid)
            {
                db.Ventas.Add(Ventas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", Ventas.CentroAtencionId);
            return View(Ventas);
        }

        // GET: Ventas/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ventas Ventas = db.Ventas.Find(Id);
            if (Ventas == null)
            {
                return HttpNotFound();
            }
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", Ventas.CentroAtencionId);
            return View(Ventas);
        }

        // POST: Ventas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VentasId,CentroAtencionId")] Ventas Ventas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Ventas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", Ventas.CentroAtencionId);
            return View(Ventas);
        }

        // GET: Ventas/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ventas Ventas = db.Ventas.Find(Id);
            if (Ventas == null)
            {
                return HttpNotFound();
            }
            return View(Ventas);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Ventas Ventas = db.Ventas.Find(Id);
            db.Ventas.Remove(Ventas);
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
