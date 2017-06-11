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
    public class EstadoEvaluacionesController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: EstadoEvaluaciones
        public ActionResult Index()
        {
            return View(db.EstadoEvaluacion.ToList());
        }

        // GET: EstadoEvaluaciones/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(Id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoEvaluaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstadoEvaluacionId,EvaluacionId")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.EstadoEvaluacion.Add(estadoEvaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluaciones/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(Id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstadoEvaluacionId,EvaluacionId")] EstadoEvaluacion estadoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoEvaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoEvaluacion);
        }

        // GET: EstadoEvaluaciones/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(Id);
            if (estadoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(estadoEvaluacion);
        }

        // POST: EstadoEvaluaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            EstadoEvaluacion estadoEvaluacion = db.EstadoEvaluacion.Find(Id);
            db.EstadoEvaluacion.Remove(estadoEvaluacion);
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
