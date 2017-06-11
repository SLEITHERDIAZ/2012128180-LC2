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

namespace LineasNuevas.Web.API.Controllers
{
    public class AdministradorEquiposController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: AdministradorEquipos
        public ActionResult Index()
        {
            return View(db.AdministradorEquipo.ToList());
        }

        // GET: AdministradorEquipos/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(Id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorEquipoId,Nombre")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                db.AdministradorEquipo.Add(administradorEquipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorEquipo);
        }

        // GET: AdministradorEquipos/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(Id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorEquipoId,Nombre")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradorEquipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipos/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(Id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            AdministradorEquipo administradorEquipo = db.AdministradorEquipo.Find(Id);
            db.AdministradorEquipo.Remove(administradorEquipo);
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
