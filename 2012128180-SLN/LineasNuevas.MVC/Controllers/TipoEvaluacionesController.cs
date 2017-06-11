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
    public class TipoEvaluacionesController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: TipoEvaluaciones
        public ActionResult Index()
        {
            return View(db.TipoEvaluacion.ToList());
        }

        // GET: TipoEvaluaciones/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(Id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEvaluaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoEvaluacionId,EvaluacionId")] TipoEvaluacion tipoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.TipoEvaluacion.Add(tipoEvaluacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluaciones/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(Id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // POST: TipoEvaluaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoEvaluacionId,EvaluacionId")] TipoEvaluacion tipoEvaluacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEvaluacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEvaluacion);
        }

        // GET: TipoEvaluaciones/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(Id);
            if (tipoEvaluacion == null)
            {
                return HttpNotFound();
            }
            return View(tipoEvaluacion);
        }

        // POST: TipoEvaluaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            TipoEvaluacion tipoEvaluacion = db.TipoEvaluacion.Find(Id);
            db.TipoEvaluacion.Remove(tipoEvaluacion);
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
