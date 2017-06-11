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
    public class TipoEvaluacionController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/TipoEvaluacion
        public IQueryable<TipoEvaluacion> GetTipoEvaluacion()
        {
            return db.TipoEvaluacion;
        }

        // GET api/TipoEvaluacion/5
        [ResponseType(typeof(TipoEvaluacion))]
        public IHttpActionResult GetTipoEvaluacion(int Id)
        {
            TipoEvaluacion tipoevaluacion = db.TipoEvaluacion.Find(Id);
            if (tipoevaluacion == null)
            {
                return NotFound();
            }

            return Ok(tipoevaluacion);
        }

        // PUT api/TipoEvaluacion/5
        public IHttpActionResult PutTipoEvaluacion(int Id, TipoEvaluacion tipoevaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != tipoevaluacion.TipoEvaluacionId)
            {
                return BadRequest();
            }

            db.Entry(tipoevaluacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEvaluacionExists(Id))
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

        // POST api/TipoEvaluacion
        [ResponseType(typeof(TipoEvaluacion))]
        public IHttpActionResult PostTipoEvaluacion(TipoEvaluacion tipoevaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoEvaluacion.Add(tipoevaluacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = tipoevaluacion.TipoEvaluacionId }, tipoevaluacion);
        }

        // DELETE api/TipoEvaluacion/5
        [ResponseType(typeof(TipoEvaluacion))]
        public IHttpActionResult DeleteTipoEvaluacion(int Id)
        {
            TipoEvaluacion tipoevaluacion = db.TipoEvaluacion.Find(Id);
            if (tipoevaluacion == null)
            {
                return NotFound();
            }

            db.TipoEvaluacion.Remove(tipoevaluacion);
            db.SaveChanges();

            return Ok(tipoevaluacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoEvaluacionExists(int Id)
        {
            return db.TipoEvaluacion.Count(e => e.TipoEvaluacionId == Id) > 0;
        }
    }
}