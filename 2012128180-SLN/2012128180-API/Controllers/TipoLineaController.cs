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
    public class TipoLineaController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/TipoLinea
        public IQueryable<TipoLinea> GetTipoLinea()
        {
            return db.TipoLinea;
        }

        // GET api/TipoLinea/5
        [ResponseType(typeof(TipoLinea))]
        public IHttpActionResult GetTipoLinea(int Id)
        {
            TipoLinea tipolinea = db.TipoLinea.Find(Id);
            if (tipolinea == null)
            {
                return NotFound();
            }

            return Ok(tipolinea);
        }

        // PUT api/TipoLinea/5
        public IHttpActionResult PutTipoLinea(int Id, TipoLinea tipolinea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != tipolinea.TipoLineaId)
            {
                return BadRequest();
            }

            db.Entry(tipolinea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoLineaExists(Id))
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

        // POST api/TipoLinea
        [ResponseType(typeof(TipoLinea))]
        public IHttpActionResult PostTipoLinea(TipoLinea tipolinea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoLinea.Add(tipolinea);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = tipolinea.TipoLineaId }, tipolinea);
        }

        // DELETE api/TipoLinea/5
        [ResponseType(typeof(TipoLinea))]
        public IHttpActionResult DeleteTipoLinea(int Id)
        {
            TipoLinea tipolinea = db.TipoLinea.Find(Id);
            if (tipolinea == null)
            {
                return NotFound();
            }

            db.TipoLinea.Remove(tipolinea);
            db.SaveChanges();

            return Ok(tipolinea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoLineaExists(int Id)
        {
            return db.TipoLinea.Count(e => e.TipoLineaId == Id) > 0;
        }
    }
}