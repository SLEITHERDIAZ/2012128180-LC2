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
    public class EquipoCelularController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/EquipoCelular
        public IQueryable<EquipoCelular> GetEquipoCelular()
        {
            return db.EquipoCelular;
        }

        // GET api/EquipoCelular/5
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult GetEquipoCelular(int Id)
        {
            EquipoCelular equipocelular = db.EquipoCelular.Find(Id);
            if (equipocelular == null)
            {
                return NotFound();
            }

            return Ok(equipocelular);
        }

        // PUT api/EquipoCelular/5
        public IHttpActionResult PutEquipoCelular(int Id, EquipoCelular equipocelular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != equipocelular.EquipoCelularId)
            {
                return BadRequest();
            }

            db.Entry(equipocelular).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoCelularExists(Id))
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

        // POST api/EquipoCelular
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult PostEquipoCelular(EquipoCelular equipocelular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EquipoCelular.Add(equipocelular);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = equipocelular.EquipoCelularId }, equipocelular);
        }

        // DELETE api/EquipoCelular/5
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult DeleteEquipoCelular(int Id)
        {
            EquipoCelular equipocelular = db.EquipoCelular.Find(Id);
            if (equipocelular == null)
            {
                return NotFound();
            }

            db.EquipoCelular.Remove(equipocelular);
            db.SaveChanges();

            return Ok(equipocelular);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EquipoCelularExists(int Id)
        {
            return db.EquipoCelular.Count(e => e.EquipoCelularId == Id) > 0;
        }
    }
}