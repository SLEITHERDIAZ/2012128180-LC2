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
    public class AdministradorEquipoesController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: AdministradorEquipoes
        public ActionResult Index()
        {
            return View(db.AdministradorEquipo.ToList());
        }

        // GET: AdministradorEquipoes/Details/5
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

        // GET: AdministradorEquipoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipoes/Create
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

        // GET: AdministradorEquipoes/Edit/5
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

        // POST: AdministradorEquipoes/Edit/5
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

        // GET: AdministradorEquipoes/Delete/5
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

        // POST: AdministradorEquipoes/Delete/5
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
