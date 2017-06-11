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
    public class ContratoController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Contrato
        public IQueryable<Contrato> GetContrato()
        {
            return db.Contrato;
        }

        // GET api/Contrato/5
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult GetContrato(int Id)
        {
            Contrato contrato = db.Contrato.Find(Id);
            if (contrato == null)
            {
                return NotFound();
            }

            return Ok(contrato);
        }

        // PUT api/Contrato/5
        public IHttpActionResult PutContrato(int Id, Contrato contrato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != contrato.ContratoId)
            {
                return BadRequest();
            }

            db.Entry(contrato).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratoExists(Id))
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

        // POST api/Contrato
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult PostContrato(Contrato contrato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contrato.Add(contrato);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = contrato.ContratoId }, contrato);
        }

        // DELETE api/Contrato/5
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult DeleteContrato(int Id)
        {
            Contrato contrato = db.Contrato.Find(Id);
            if (contrato == null)
            {
                return NotFound();
            }

            db.Contrato.Remove(contrato);
            db.SaveChanges();

            return Ok(contrato);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContratoExists(int Id)
        {
            return db.Contrato.Count(e => e.ContratoId == Id) > 0;
        }
    }
}