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
    public class PlanController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Plan
        public IQueryable<Plan> GetPlan()
        {
            return db.Plan;
        }

        // GET api/Plan/5
        [ResponseType(typeof(Plan))]
        public IHttpActionResult GetPlan(int Id)
        {
            Plan plan = db.Plan.Find(Id);
            if (plan == null)
            {
                return NotFound();
            }

            return Ok(plan);
        }

        // PUT api/Plan/5
        public IHttpActionResult PutPlan(int Id, Plan plan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != plan.PlanId)
            {
                return BadRequest();
            }

            db.Entry(plan).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(Id))
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

        // POST api/Plan
        [ResponseType(typeof(Plan))]
        public IHttpActionResult PostPlan(Plan plan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Plan.Add(plan);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = plan.PlanId }, plan);
        }

        // DELETE api/Plan/5
        [ResponseType(typeof(Plan))]
        public IHttpActionResult DeletePlan(int Id)
        {
            Plan plan = db.Plan.Find(Id);
            if (plan == null)
            {
                return NotFound();
            }

            db.Plan.Remove(plan);
            db.SaveChanges();

            return Ok(plan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanExists(int Id)
        {
            return db.Plan.Count(e => e.PlanId == Id) > 0;
        }
    }
}