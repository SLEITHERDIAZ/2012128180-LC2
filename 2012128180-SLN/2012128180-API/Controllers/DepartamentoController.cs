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
    public class DepartamentoController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Departamento
        public IQueryable<Departamento> GetDepartamento()
        {
            return db.Departamento;
        }

        // GET api/Departamento/5
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult GetDepartamento(int Id)
        {
            Departamento departamento = db.Departamento.Find(Id);
            if (departamento == null)
            {
                return NotFound();
            }

            return Ok(departamento);
        }

        // PUT api/Departamento/5
        public IHttpActionResult PutDepartamento(int Id, Departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != departamento.DepartamentoId)
            {
                return BadRequest();
            }

            db.Entry(departamento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(Id))
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

        // POST api/Departamento
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult PostDepartamento(Departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Departamento.Add(departamento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = departamento.DepartamentoId }, departamento);
        }

        // DELETE api/Departamento/5
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult DeleteDepartamento(int Id)
        {
            Departamento departamento = db.Departamento.Find(Id);
            if (departamento == null)
            {
                return NotFound();
            }

            db.Departamento.Remove(departamento);
            db.SaveChanges();

            return Ok(departamento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartamentoExists(int Id)
        {
            return db.Departamento.Count(e => e.DepartamentoId == Id) > 0;
        }
    }
}