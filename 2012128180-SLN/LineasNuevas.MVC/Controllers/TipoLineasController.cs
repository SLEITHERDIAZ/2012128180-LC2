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
    public class TipoLineasController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: TipoLineas
        public ActionResult Index()
        {
            return View(db.TipoLinea.ToList());
        }

        // GET: TipoLineas/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(Id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // GET: TipoLineas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoLineas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoLineaId,LineaTelefonicaId")] TipoLinea tipoLinea)
        {
            if (ModelState.IsValid)
            {
                db.TipoLinea.Add(tipoLinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoLinea);
        }

        // GET: TipoLineas/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(Id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // POST: TipoLineas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoLineaId,LineaTelefonicaId")] TipoLinea tipoLinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoLinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoLinea);
        }

        // GET: TipoLineas/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoLinea tipoLinea = db.TipoLinea.Find(Id);
            if (tipoLinea == null)
            {
                return HttpNotFound();
            }
            return View(tipoLinea);
        }

        // POST: TipoLineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            TipoLinea tipoLinea = db.TipoLinea.Find(Id);
            db.TipoLinea.Remove(tipoLinea);
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
