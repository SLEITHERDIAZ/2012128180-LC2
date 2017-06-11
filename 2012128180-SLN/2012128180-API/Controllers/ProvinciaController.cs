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
    public class ProvinciaController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Provincia
        public IQueryable<Provincia> GetProvincia()
        {
            return db.Provincia;
        }

        // GET api/Provincia/5
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult GetProvincia(int Id)
        {
            Provincia provincia = db.Provincia.Find(Id);
            if (provincia == null)
            {
                return NotFound();
            }

            return Ok(provincia);
        }

        // PUT api/Provincia/5
        public IHttpActionResult PutProvincia(int Id, Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != provincia.ProvinciaId)
            {
                return BadRequest();
            }

            db.Entry(provincia).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciaExists(Id))
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

        // POST api/Provincia
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult PostProvincia(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Provincia.Add(provincia);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = provincia.ProvinciaId }, provincia);
        }

        // DELETE api/Provincia/5
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult DeleteProvincia(int Id)
        {
            Provincia provincia = db.Provincia.Find(Id);
            if (provincia == null)
            {
                return NotFound();
            }

            db.Provincia.Remove(provincia);
            db.SaveChanges();

            return Ok(provincia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProvinciaExists(int Id)
        {
            return db.Provincia.Count(e => e.ProvinciaId == Id) > 0;
        }
    }
}