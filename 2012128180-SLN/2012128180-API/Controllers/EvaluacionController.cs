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
    public class EvaluacionController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Evaluacion
        public IQueryable<Evaluacion> GetEvaluacion()
        {
            return db.Evaluacion;
        }

        // GET api/Evaluacion/5
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult GetEvaluacion(int Id)
        {
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            if (evaluacion == null)
            {
                return NotFound();
            }

            return Ok(evaluacion);
        }

        // PUT api/Evaluacion/5
        public IHttpActionResult PutEvaluacion(int Id, Evaluacion evaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != evaluacion.EvaluacionId)
            {
                return BadRequest();
            }

            db.Entry(evaluacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluacionExists(Id))
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

        // POST api/Evaluacion
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult PostEvaluacion(Evaluacion evaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Evaluacion.Add(evaluacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = evaluacion.EvaluacionId }, evaluacion);
        }

        // DELETE api/Evaluacion/5
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult DeleteEvaluacion(int Id)
        {
            Evaluacion evaluacion = db.Evaluacion.Find(Id);
            if (evaluacion == null)
            {
                return NotFound();
            }

            db.Evaluacion.Remove(evaluacion);
            db.SaveChanges();

            return Ok(evaluacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EvaluacionExists(int Id)
        {
            return db.Evaluacion.Count(e => e.EvaluacionId == Id) > 0;
        }
    }
}