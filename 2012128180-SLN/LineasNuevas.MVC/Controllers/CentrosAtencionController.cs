
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
    public class CentrosAtencionController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: CentrosAtencion
        public ActionResult Index()
        {
            return View(db.CentroAtencion.ToList());
        }

        // GET: CentrosAtencion/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(Id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // GET: CentrosAtencion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CentrosAtencion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CentroAtencionId,DireccionId,EvaluacionId,VentasId")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.CentroAtencion.Add(centroAtencion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(centroAtencion);
        }

        // GET: CentrosAtencion/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(Id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentrosAtencion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CentroAtencionId,DireccionId,EvaluacionId,VentasId")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centroAtencion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(centroAtencion);
        }

        // GET: CentrosAtencion/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = db.CentroAtencion.Find(Id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentrosAtencion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            CentroAtencion centroAtencion = db.CentroAtencion.Find(Id);
            db.CentroAtencion.Remove(centroAtencion);
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
