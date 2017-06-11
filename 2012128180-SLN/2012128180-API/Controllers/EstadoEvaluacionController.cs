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
    public class EstadoEvaluacionController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/EstadoEvaluacion
        public IQueryable<EstadoEvaluacion> GetEstadoEvaluacion()
        {
            return db.EstadoEvaluacion;
        }

        // GET api/EstadoEvaluacion/5
        [ResponseType(typeof(EstadoEvaluacion))]
        public IHttpActionResult GetEstadoEvaluacion(int Id)
        {
            EstadoEvaluacion estadoevaluacion = db.EstadoEvaluacion.Find(Id);
            if (estadoevaluacion == null)
            {
                return NotFound();
            }

            return Ok(estadoevaluacion);
        }

        // PUT api/EstadoEvaluacion/5
        public IHttpActionResult PutEstadoEvaluacion(int Id, EstadoEvaluacion estadoevaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != estadoevaluacion.EstadoEvaluacionId)
            {
                return BadRequest();
            }

            db.Entry(estadoevaluacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoEvaluacionExists(Id))
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

        // POST api/EstadoEvaluacion
        [ResponseType(typeof(EstadoEvaluacion))]
        public IHttpActionResult PostEstadoEvaluacion(EstadoEvaluacion estadoevaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EstadoEvaluacion.Add(estadoevaluacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = estadoevaluacion.EstadoEvaluacionId }, estadoevaluacion);
        }

        // DELETE api/EstadoEvaluacion/5
        [ResponseType(typeof(EstadoEvaluacion))]
        public IHttpActionResult DeleteEstadoEvaluacion(int Id)
        {
            EstadoEvaluacion estadoevaluacion = db.EstadoEvaluacion.Find(Id);
            if (estadoevaluacion == null)
            {
                return NotFound();
            }

            db.EstadoEvaluacion.Remove(estadoevaluacion);
            db.SaveChanges();

            return Ok(estadoevaluacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EstadoEvaluacionExists(int Id)
        {
            return db.EstadoEvaluacion.Count(e => e.EstadoEvaluacionId == Id) > 0;
        }
    }
}