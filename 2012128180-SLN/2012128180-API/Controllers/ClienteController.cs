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
    public class ClienteController : ApiController
    {
        private JeffdiazDbContext db = new JeffdiazDbContext();

        // GET api/Cliente
        public IQueryable<Cliente> GetCliente()
        {
            return db.Cliente;
        }

        // GET api/Cliente/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult GetCliente(int Id)
        {
            Cliente cliente = db.Cliente.Find(Id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // PUT api/Cliente/5
        public IHttpActionResult PutCliente(int Id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != cliente.ClienteId)
            {
                return BadRequest();
            }

            db.Entry(cliente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(Id))
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

        // POST api/Cliente
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cliente.Add(cliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { Id = cliente.ClienteId }, cliente);
        }

        // DELETE api/Cliente/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult DeleteCliente(int Id)
        {
            Cliente cliente = db.Cliente.Find(Id);
            if (cliente == null)
            {
                return NotFound();
            }

            db.Cliente.Remove(cliente);
            db.SaveChanges();

            return Ok(cliente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClienteExists(int Id)
        {
            return db.Cliente.Count(e => e.ClienteId == Id) > 0;
        }
    }
}