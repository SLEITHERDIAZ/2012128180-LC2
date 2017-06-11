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
    public class TipoTrabajadoresController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: TipoTrabajadores
        public ActionResult Index()
        {
            return View(db.TipoTrabajador.ToList());
        }

        // GET: TipoTrabajadores/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(Id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTrabajadores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTrabajadorId,TrabajadorId")] TipoTrabajador tipoTrabajador)
        {
            if (ModelState.IsValid)
            {
                db.TipoTrabajador.Add(tipoTrabajador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadores/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(Id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // POST: TipoTrabajadores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTrabajadorId,TrabajadorId")] TipoTrabajador tipoTrabajador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTrabajador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTrabajador);
        }

        // GET: TipoTrabajadores/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(Id);
            if (tipoTrabajador == null)
            {
                return HttpNotFound();
            }
            return View(tipoTrabajador);
        }

        // POST: TipoTrabajadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            TipoTrabajador tipoTrabajador = db.TipoTrabajador.Find(Id);
            db.TipoTrabajador.Remove(tipoTrabajador);
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
