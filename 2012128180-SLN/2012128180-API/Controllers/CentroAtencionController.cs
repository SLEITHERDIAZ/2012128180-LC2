using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2012128180_EN.Entities;
using _2012128180_PER.Persistence;

namespace _2012128080_API.Controllers
{
    public class CentroAtencionController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/CentroAtencion
        public IQueryable<CentroAtencion> GetCentroAtencion()
        {
            return db.CentroAtencion;
        }

        // GET api/CentroAtencion/5
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult GetCentroAtencion(int Id)
        {
            CentroAtencion centroatencion = db.CentroAtencion.Find(Id);
            if (centroatencion == null)
            {
                return NotFound();
            }

            return Ok(centroatencion);
        }

        // PUT api/CentroAtencion/5
        public IHttpActionResult PutCentroAtencion(int Id, CentroAtencion centroatencion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != centroatencion.CentroAtencionId)
            {
                return BadRequest();
            }

            db.Entry(centroatencion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroAtencionExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/CentroAtencion
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult PostCentroAtencion(CentroAtencion centroatencion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CentroAtencion.Add(centroatencion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = centroatencion.CentroAtencionId }, centroatencion);
        }

        // DELETE api/CentroAtencion/5
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult DeleteCentroAtencion(int Id)
        {
            CentroAtencion centroatencion = db.CentroAtencion.Find(Id);
            if (centroatencion == null)
            {
                return NotFound();
            }

            db.CentroAtencion.Remove(centroatencion);
            db.SaveChanges();

            return Ok(centroatencion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CentroAtencionExists(int Id)
        {
            return db.CentroAtencion.Count(e => e.CentroAtencionId == Id) > 0;
        }
    }
}