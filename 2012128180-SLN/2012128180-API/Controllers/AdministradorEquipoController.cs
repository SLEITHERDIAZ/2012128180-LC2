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
    public class AdministradorEquipoController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/AdministradorEquipo
        public IQueryable<AdministradorEquipo> GetAdministradorEquipo()
        {   
            return db.AdministradorEquipo;
        }

        // GET api/AdministradorEquipo/5
        [ResponseType(typeof(AdministradorEquipo))]
        public IHttpActionResult GetAdministradorEquipo(int Id)
        {
            AdministradorEquipo administradorequipo = db.AdministradorEquipo.Find(Id);
            if (administradorequipo == null)
            {
                return NotFound();
            }

            return Ok(administradorequipo);
        }

        // PUT api/AdministradorEquipo/5
        public IHttpActionResult PutAdministradorEquipo(int Id, AdministradorEquipo administradorequipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != administradorequipo.AdministradorEquipoId)
            {
                return BadRequest();
            }

            db.Entry(administradorequipo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorEquipoExists(Id))
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

        // POST api/AdministradorEquipo
        [ResponseType(typeof(AdministradorEquipo))]
        public IHttpActionResult PostAdministradorEquipo(AdministradorEquipo administradorequipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AdministradorEquipo.Add(administradorequipo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = administradorequipo.AdministradorEquipoId }, administradorequipo);
        }

        // DELETE api/AdministradorEquipo/5
        [ResponseType(typeof(AdministradorEquipo))]
        public IHttpActionResult DeleteAdministradorEquipo(int Id)
        {
            AdministradorEquipo administradorequipo = db.AdministradorEquipo.Find(Id);
            if (administradorequipo == null)
            {
                return NotFound();
            }

            db.AdministradorEquipo.Remove(administradorequipo);
            db.SaveChanges();

            return Ok(administradorequipo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdministradorEquipoExists(int Id)
        {
            return db.AdministradorEquipo.Count(e => e.AdministradorEquipoId == Id) > 0;
        }
    }
}