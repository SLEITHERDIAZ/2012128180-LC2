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
    public class DireccionController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Direccion
        public IQueryable<Direccion> GetDireccion()
        {
            return db.Direccion;
        }

        // GET api/Direccion/5
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult GetDireccion(int Id)
        {
            Direccion direccion = db.Direccion.Find(Id);
            if (direccion == null)
            {
                return NotFound();
            }

            return Ok(direccion);
        }

        // PUT api/Direccion/5
        public IHttpActionResult PutDireccion(int Id, Direccion direccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != direccion.DireccionId)
            {
                return BadRequest();
            }

            db.Entry(direccion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DireccionExists(Id))
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

        // POST api/Direccion
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult PostDireccion(Direccion direccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Direccion.Add(direccion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = direccion.DireccionId }, direccion);
        }

        // DELETE api/Direccion/5
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult DeleteDireccion(int Id)
        {
            Direccion direccion = db.Direccion.Find(Id);
            if (direccion == null)
            {
                return NotFound();
            }

            db.Direccion.Remove(direccion);
            db.SaveChanges();

            return Ok(direccion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DireccionExists(int Id)
        {
            return db.Direccion.Count(e => e.DireccionId == Id) > 0;
        }
    }
}