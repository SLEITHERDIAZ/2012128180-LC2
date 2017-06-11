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
    public class DistritoController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Distrito
        public IQueryable<Distrito> GetDistrito()
        {
            return db.Distrito;
        }

        // GET api/Distrito/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult GetDistrito(int Id)
        {
            Distrito distrito = db.Distrito.Find(Id);
            if (distrito == null)
            {
                return NotFound();
            }

            return Ok(distrito);
        }

        // PUT api/Distrito/5
        public IHttpActionResult PutDistrito(int Id, Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != distrito.DistritoId)
            {
                return BadRequest();
            }

            db.Entry(distrito).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistritoExists(Id))
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

        // POST api/Distrito
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult PostDistrito(Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Distrito.Add(distrito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = distrito.DistritoId }, distrito);
        }

        // DELETE api/Distrito/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult DeleteDistrito(int Id)
        {
            Distrito distrito = db.Distrito.Find(Id);
            if (distrito == null)
            {
                return NotFound();
            }

            db.Distrito.Remove(distrito);
            db.SaveChanges();

            return Ok(distrito);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DistritoExists(int Id)
        {
            return db.Distrito.Count(e => e.DistritoId == Id) > 0;
        }
    }
}