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
    public class AdministradorLineaController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/AdministradorLinea
        public IQueryable<AdministradorLinea> GetAdministradorLinea()
        {
            return db.AdministradorLinea;
        }

        // GET api/AdministradorLinea/5
        [ResponseType(typeof(AdministradorLinea))]
        public IHttpActionResult GetAdministradorLinea(int Id)
        {
            AdministradorLinea administradorlinea = db.AdministradorLinea.Find(Id);
            if (administradorlinea == null)
            {
                return NotFound();
            }

            return Ok(administradorlinea);
        }

        // PUT api/AdministradorLinea/5
        public IHttpActionResult PutAdministradorLinea(int Id, AdministradorLinea administradorlinea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != administradorlinea.AdministradorLineaId)
            {
                return BadRequest();
            }

            db.Entry(administradorlinea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorLineaExists(Id))
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

        // POST api/AdministradorLinea
        [ResponseType(typeof(AdministradorLinea))]
        public IHttpActionResult PostAdministradorLinea(AdministradorLinea administradorlinea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AdministradorLinea.Add(administradorlinea);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = administradorlinea.AdministradorLineaId }, administradorlinea);
        }

        // DELETE api/AdministradorLinea/5
        [ResponseType(typeof(AdministradorLinea))]
        public IHttpActionResult DeleteAdministradorLinea(int Id)
        {
            AdministradorLinea administradorlinea = db.AdministradorLinea.Find(Id);
            if (administradorlinea == null)
            {
                return NotFound();
            }

            db.AdministradorLinea.Remove(administradorlinea);
            db.SaveChanges();

            return Ok(administradorlinea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdministradorLineaExists(int Id)
        {
            return db.AdministradorLinea.Count(e => e.AdministradorLineaId == Id) > 0;
        }
    }
}