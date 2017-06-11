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
    public class EquiposCelularController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: EquiposCelular
        public ActionResult Index()
        {
            var equipoCelular = db.EquipoCelular.Include(e => e.AdministradorEquipo);
            return View(equipoCelular.ToList());
        }

        // GET: EquiposCelular/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(Id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // GET: EquiposCelular/Create
        public ActionResult Create()
        {
            ViewBag.AdministradorEquipoId = new SelectList(db.AdministradorEquipo, "AdministradorEquipoId", "Nombre");
            return View();
        }

        // POST: EquiposCelular/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoCelularId,Nombre,AdministradorEquipoId")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.EquipoCelular.Add(equipoCelular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministradorEquipoId = new SelectList(db.AdministradorEquipo, "AdministradorEquipoId", "Nombre", equipoCelular.AdministradorEquipoId);
            return View(equipoCelular);
        }

        // GET: EquiposCelular/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(Id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradorEquipoId = new SelectList(db.AdministradorEquipo, "AdministradorEquipoId", "Nombre", equipoCelular.AdministradorEquipoId);
            return View(equipoCelular);
        }

        // POST: EquiposCelular/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoCelularId,Nombre,AdministradorEquipoId")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipoCelular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministradorEquipoId = new SelectList(db.AdministradorEquipo, "AdministradorEquipoId", "Nombre", equipoCelular.AdministradorEquipoId);
            return View(equipoCelular);
        }

        // GET: EquiposCelular/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = db.EquipoCelular.Find(Id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquiposCelular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            EquipoCelular equipoCelular = db.EquipoCelular.Find(Id);
            db.EquipoCelular.Remove(equipoCelular);
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
