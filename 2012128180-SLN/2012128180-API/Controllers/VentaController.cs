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
    public class VentasController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Ventas
        public IQueryable<Ventas> GetVentas()
        {
            return db.Ventas;
        }

        // GET api/Ventas/5
        [ResponseType(typeof(Ventas))]
        public IHttpActionResult GetVentas(int Id)
        {
            Ventas Ventas = db.Ventas.Find(Id);
            if (Ventas == null)
            {
                return NotFound();
            }

            return Ok(Ventas);
        }

        // PUT api/Ventas/5
        public IHttpActionResult PutVentas(int Id, Ventas Ventas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != Ventas.VentasId)
            {
                return BadRequest();
            }

            db.Entry(Ventas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentasExists(Id))
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

        // POST api/Ventas
        [ResponseType(typeof(Ventas))]
        public IHttpActionResult PostVentas(Ventas Ventas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ventas.Add(Ventas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = Ventas.VentasId }, Ventas);
        }

        // DELETE api/Ventas/5
        [ResponseType(typeof(Ventas))]
        public IHttpActionResult DeleteVentas(int Id)
        {
            Ventas Ventas = db.Ventas.Find(Id);
            if (Ventas == null)
            {
                return NotFound();
            }

            db.Ventas.Remove(Ventas);
            db.SaveChanges();

            return Ok(Ventas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VentasExists(int Id)
        {
            return db.Ventas.Count(e => e.VentasId == Id) > 0;
        }
    }
}