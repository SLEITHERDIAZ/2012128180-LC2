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
    public class TipoTrabajadorController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/TipoTrabajador
        public IQueryable<TipoTrabajador> GetTipoTrabajador()
        {
            return db.TipoTrabajador;
        }

        // GET api/TipoTrabajador/5
        [ResponseType(typeof(TipoTrabajador))]
        public IHttpActionResult GetTipoTrabajador(int Id)
        {
            TipoTrabajador tipotrabajador = db.TipoTrabajador.Find(Id);
            if (tipotrabajador == null)
            {
                return NotFound();
            }

            return Ok(tipotrabajador);
        }

        // PUT api/TipoTrabajador/5
        public IHttpActionResult PutTipoTrabajador(int Id, TipoTrabajador tipotrabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != tipotrabajador.TipoTrabajadorId)
            {
                return BadRequest();
            }

            db.Entry(tipotrabajador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoTrabajadorExists(Id))
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

        // POST api/TipoTrabajador
        [ResponseType(typeof(TipoTrabajador))]
        public IHttpActionResult PostTipoTrabajador(TipoTrabajador tipotrabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoTrabajador.Add(tipotrabajador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = tipotrabajador.TipoTrabajadorId }, tipotrabajador);
        }

        // DELETE api/TipoTrabajador/5
        [ResponseType(typeof(TipoTrabajador))]
        public IHttpActionResult DeleteTipoTrabajador(int Id)
        {
            TipoTrabajador tipotrabajador = db.TipoTrabajador.Find(Id);
            if (tipotrabajador == null)
            {
                return NotFound();
            }

            db.TipoTrabajador.Remove(tipotrabajador);
            db.SaveChanges();

            return Ok(tipotrabajador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoTrabajadorExists(int Id)
        {
            return db.TipoTrabajador.Count(e => e.TipoTrabajadorId == Id) > 0;
        }
    }
}