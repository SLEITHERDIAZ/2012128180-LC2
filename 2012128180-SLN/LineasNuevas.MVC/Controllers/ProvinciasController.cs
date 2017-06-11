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
    public class ProvinciasController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: Provincias
        public ActionResult Index()
        {
            var provincia = db.Provincia.Include(p => p.Departamento);
            return View(provincia.ToList());
        }

        // GET: Provincias/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = db.Provincia.Find(Id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // GET: Provincias/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "NombreDepar");
            return View();
        }

        // POST: Provincias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProvinciaId,NombrePro,CadenaUbigeo,DepartamentoId")] Provincia provincia)
        {
            if (ModelState.IsValid)
            {
                db.Provincia.Add(provincia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "NombreDepar", provincia.DepartamentoId);
            return View(provincia);
        }

        // GET: Provincias/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = db.Provincia.Find(Id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "NombreDepar", provincia.DepartamentoId);
            return View(provincia);
        }

        // POST: Provincias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProvinciaId,NombrePro,CadenaUbigeo,DepartamentoId")] Provincia provincia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provincia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "NombreDepar", provincia.DepartamentoId);
            return View(provincia);
        }

        // GET: Provincias/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = db.Provincia.Find(Id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // POST: Provincias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            Provincia provincia = db.Provincia.Find(Id);
            db.Provincia.Remove(provincia);
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
