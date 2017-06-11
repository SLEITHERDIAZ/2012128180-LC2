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
    public class LineasTelefonicasController : Controller
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET: LineasTelefonicas
        public ActionResult Index()
        {
            var lineaTelefonica = db.LineaTelefonica.Include(l => l.AdministradorLinea).Include(l => l.Ventas);
            return View(lineaTelefonica.ToList());
        }

        // GET: LineasTelefonicas/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(Id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // GET: LineasTelefonicas/Create
        public ActionResult Create()
        {
            ViewBag.AdministradorLineaId = new SelectList(db.AdministradorLinea, "AdministradorLineaId", "Nombre");
            ViewBag.LineaTelefonicaId = new SelectList(db.Ventas, "VentasId", "VentasId");
            return View();
        }

        // POST: LineasTelefonicas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaTelefonicaId,AdministradorLineaId,VentasId,EvaluacionId")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.LineaTelefonica.Add(lineaTelefonica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministradorLineaId = new SelectList(db.AdministradorLinea, "AdministradorLineaId", "Nombre", lineaTelefonica.AdministradorLineaId);
            ViewBag.LineaTelefonicaId = new SelectList(db.Ventas, "VentasId", "VentasId", lineaTelefonica.LineaTelefonicaId);
            return View(lineaTelefonica);
        }

        // GET: LineasTelefonicas/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(Id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministradorLineaId = new SelectList(db.AdministradorLinea, "AdministradorLineaId", "Nombre", lineaTelefonica.AdministradorLineaId);
            ViewBag.LineaTelefonicaId = new SelectList(db.Ventas, "VentasId", "VentasId", lineaTelefonica.LineaTelefonicaId);
            return View(lineaTelefonica);
        }

        // POST: LineasTelefonicas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaTelefonicaId,AdministradorLineaId,VentasId,EvaluacionId")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineaTelefonica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministradorLineaId = new SelectList(db.AdministradorLinea, "AdministradorLineaId", "Nombre", lineaTelefonica.AdministradorLineaId);
            ViewBag.LineaTelefonicaId = new SelectList(db.Ventas, "VentasId", "VentasId", lineaTelefonica.LineaTelefonicaId);
            return View(lineaTelefonica);
        }

        // GET: LineasTelefonicas/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(Id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineasTelefonicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(Id);
            db.LineaTelefonica.Remove(lineaTelefonica);
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
