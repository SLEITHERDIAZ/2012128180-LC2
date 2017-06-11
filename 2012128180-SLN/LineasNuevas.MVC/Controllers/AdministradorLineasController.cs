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
    public class AdministradorLineasController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: AdministradorLineas
        public ActionResult Index()
        {
            return View(db.AdministradorLinea.ToList());
        }

        // GET: AdministradorLineas/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(Id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // GET: AdministradorLineas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorLineas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorLineaId,Nombre")] AdministradorLinea administradorLinea)
        {
            if (ModelState.IsValid)
            {
                db.AdministradorLinea.Add(administradorLinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorLinea);
        }

        // GET: AdministradorLineas/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(Id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // POST: AdministradorLineas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorLineaId,Nombre")] AdministradorLinea administradorLinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradorLinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorLinea);
        }

        // GET: AdministradorLineas/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(Id);
            if (administradorLinea == null)
            {
                return HttpNotFound();
            }
            return View(administradorLinea);
        }

        // POST: AdministradorLineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            AdministradorLinea administradorLinea = db.AdministradorLinea.Find(Id);
            db.AdministradorLinea.Remove(administradorLinea);
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
