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
    public class TipoPlanController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/TipoPlan
        public IQueryable<TipoPlan> GetTipoPlan()
        {
            return db.TipoPlan;
        }

        // GET api/TipoPlan/5
        [ResponseType(typeof(TipoPlan))]
        public IHttpActionResult GetTipoPlan(int Id)
        {
            TipoPlan tipoplan = db.TipoPlan.Find(Id);
            if (tipoplan == null)
            {
                return NotFound();
            }

            return Ok(tipoplan);
        }

        // PUT api/TipoPlan/5
        public IHttpActionResult PutTipoPlan(int Id, TipoPlan tipoplan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != tipoplan.TipoPlanId)
            {
                return BadRequest();
            }

            db.Entry(tipoplan).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPlanExists(Id))
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

        // POST api/TipoPlan
        [ResponseType(typeof(TipoPlan))]
        public IHttpActionResult PostTipoPlan(TipoPlan tipoplan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoPlan.Add(tipoplan);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = tipoplan.TipoPlanId }, tipoplan);
        }

        // DELETE api/TipoPlan/5
        [ResponseType(typeof(TipoPlan))]
        public IHttpActionResult DeleteTipoPlan(int Id)
        {
            TipoPlan tipoplan = db.TipoPlan.Find(Id);
            if (tipoplan == null)
            {
                return NotFound();
            }

            db.TipoPlan.Remove(tipoplan);
            db.SaveChanges();

            return Ok(tipoplan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoPlanExists(int Id)
        {
            return db.TipoPlan.Count(e => e.TipoPlanId == Id) > 0;
        }
    }
}