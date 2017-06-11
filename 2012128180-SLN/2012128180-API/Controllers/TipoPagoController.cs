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
    public class TipoPagoController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/TipoPago
        public IQueryable<TipoPago> GetTipoPago()
        {
            return db.TipoPago;
        }

        // GET api/TipoPago/5
        [ResponseType(typeof(TipoPago))]
        public IHttpActionResult GetTipoPago(int Id)
        {
            TipoPago tipopago = db.TipoPago.Find(Id);
            if (tipopago == null)
            {
                return NotFound();
            }

            return Ok(tipopago);
        }

        // PUT api/TipoPago/5
        public IHttpActionResult PutTipoPago(int Id, TipoPago tipopago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != tipopago.TipoPagoId)
            {
                return BadRequest();
            }

            db.Entry(tipopago).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPagoExists(Id))
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

        // POST api/TipoPago
        [ResponseType(typeof(TipoPago))]
        public IHttpActionResult PostTipoPago(TipoPago tipopago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoPago.Add(tipopago);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = tipopago.TipoPagoId }, tipopago);
        }

        // DELETE api/TipoPago/5
        [ResponseType(typeof(TipoPago))]
        public IHttpActionResult DeleteTipoPago(int Id)
        {
            TipoPago tipopago = db.TipoPago.Find(Id);
            if (tipopago == null)
            {
                return NotFound();
            }

            db.TipoPago.Remove(tipopago);
            db.SaveChanges();

            return Ok(tipopago);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoPagoExists(int Id)
        {
            return db.TipoPago.Count(e => e.TipoPagoId == Id) > 0;
        }
    }
}