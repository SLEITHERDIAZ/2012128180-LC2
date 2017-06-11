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
    public class LineaTelefonicaController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/LineaTelefonica
        public IQueryable<LineaTelefonica> GetLineaTelefonica()
        {
            return db.LineaTelefonica;
        }

        // GET api/LineaTelefonica/5
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult GetLineaTelefonica(int Id)
        {
            LineaTelefonica lineatelefonica = db.LineaTelefonica.Find(Id);
            if (lineatelefonica == null)
            {
                return NotFound();
            }

            return Ok(lineatelefonica);
        }

        // PUT api/LineaTelefonica/5
        public IHttpActionResult PutLineaTelefonica(int Id, LineaTelefonica lineatelefonica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != lineatelefonica.LineaTelefonicaId)
            {
                return BadRequest();
            }

            db.Entry(lineatelefonica).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaTelefonicaExists(Id))
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

        // POST api/LineaTelefonica
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult PostLineaTelefonica(LineaTelefonica lineatelefonica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LineaTelefonica.Add(lineatelefonica);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = lineatelefonica.LineaTelefonicaId }, lineatelefonica);
        }

        // DELETE api/LineaTelefonica/5
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult DeleteLineaTelefonica(int Id)
        {
            LineaTelefonica lineatelefonica = db.LineaTelefonica.Find(Id);
            if (lineatelefonica == null)
            {
                return NotFound();
            }

            db.LineaTelefonica.Remove(lineatelefonica);
            db.SaveChanges();

            return Ok(lineatelefonica);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LineaTelefonicaExists(int Id)
        {
            return db.LineaTelefonica.Count(e => e.LineaTelefonicaId == Id) > 0;
        }
    }
}