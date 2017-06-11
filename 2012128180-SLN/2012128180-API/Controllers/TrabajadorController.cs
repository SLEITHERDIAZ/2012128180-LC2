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
    public class TrabajadorController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Trabajador
        public IQueryable<Trabajador> GetTrabajador()
        {
            return db.Trabajador;
        }

        // GET api/Trabajador/5
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult GetTrabajador(int Id)
        {
            Trabajador trabajador = db.Trabajador.Find(Id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return Ok(trabajador);
        }

        // PUT api/Trabajador/5
        public IHttpActionResult PutTrabajador(int Id, Trabajador trabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != trabajador.TrabajadorId)
            {
                return BadRequest();
            }

            db.Entry(trabajador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrabajadorExists(Id))
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

        // POST api/Trabajador
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult PostTrabajador(Trabajador trabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Trabajador.Add(trabajador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = trabajador.TrabajadorId }, trabajador);
        }

        // DELETE api/Trabajador/5
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult DeleteTrabajador(int Id)
        {
            Trabajador trabajador = db.Trabajador.Find(Id);
            if (trabajador == null)
            {
                return NotFound();
            }

            db.Trabajador.Remove(trabajador);
            db.SaveChanges();

            return Ok(trabajador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrabajadorExists(int Id)
        {
            return db.Trabajador.Count(e => e.TrabajadorId == Id) > 0;
        }
    }
}