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
    public class DireccionesController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: Direcciones
        public ActionResult Index()
        {
            var direccion = db.Direccion.Include(d => d.CentroAtencion).Include(d => d.Distrito);
            return View(direccion.ToList());
        }

        // GET: Direcciones/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direccion.Find(Id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // GET: Direcciones/Create
        public ActionResult Create()
        {
            ViewBag.DireccionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId");
            ViewBag.DistritoId = new SelectList(db.Distrito, "DistritoId", "NombreDis");
            return View();
        }

        // POST: Direcciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DireccionId,NombreDire,CentroAtencionId,DistritoId")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                db.Direccion.Add(direccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DireccionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", direccion.DireccionId);
            ViewBag.DistritoId = new SelectList(db.Distrito, "DistritoId", "NombreDis", direccion.DistritoId);
            return View(direccion);
        }

        // GET: Direcciones/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direccion.Find(Id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.DireccionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", direccion.DireccionId);
            ViewBag.DistritoId = new SelectList(db.Distrito, "DistritoId", "NombreDis", direccion.DistritoId);
            return View(direccion);
        }

        // POST: Direcciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DireccionId,NombreDire,CentroAtencionId,DistritoId")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(direccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DireccionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "CentroAtencionId", direccion.DireccionId);
            ViewBag.DistritoId = new SelectList(db.Distrito, "DistritoId", "NombreDis", direccion.DistritoId);
            return View(direccion);
        }

        // GET: Direcciones/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direccion.Find(Id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // POST: Direcciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Direccion direccion = db.Direccion.Find(Id);
            db.Direccion.Remove(direccion);
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
