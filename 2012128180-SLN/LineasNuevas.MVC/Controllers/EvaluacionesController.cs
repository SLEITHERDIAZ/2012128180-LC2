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
    public class EvaluacionesController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: Evaluaciones
        public ActionResult Index()
        {
            var evaluacion = db.Evaluacion.Include(e => e.CentroAtencion).Include(e => e.Trabajador).Include(e => e.Ventas);
            return View(evaluacion.ToList());
        }

        // GET: Evaluaciones/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // GET: Evaluaciones/Create
        public ActionResult Create()
        {
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId");
            ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTra");
            ViewBag.EvaluacionId = new SelectList(db.Ventas, "VentasId", "VentasId");
            return View();
        }

        // POST: Evaluaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluacionId,VentasId,TrabajadorId,CentroAtencionId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Evaluacion.Add(evaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", evaluacion.CentroAtencionId);
            ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTra", evaluacion.TrabajadorId);
            ViewBag.EvaluacionId = new SelectList(db.Ventas, "VentasId", "VentasId", evaluacion.EvaluacionId);
            return View(evaluacion);
        }

        // GET: Evaluaciones/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", evaluacion.CentroAtencionId);
            ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTra", evaluacion.TrabajadorId);
            ViewBag.EvaluacionId = new SelectList(db.Ventas, "VentasId", "VentasId", evaluacion.EvaluacionId);
            return View(evaluacion);
        }

        // POST: Evaluaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluacionId,VentasId,TrabajadorId,CentroAtencionId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", evaluacion.CentroAtencionId);
            ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTra", evaluacion.TrabajadorId);
            ViewBag.EvaluacionId = new SelectList(db.Ventas, "VentasId", "VentasId", evaluacion.EvaluacionId);
            return View(evaluacion);
        }

        // GET: Evaluaciones/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            db.Evaluacion.Remove(evaluacion);
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
