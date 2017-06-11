using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using _2012128180_ENT.EntitiesDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LineasNuevas.Web.API.Controllers
{
    public class AdministradorLineasController : ApiController
    {
        private readonly IUnityOfWork _unityOfWork;

        public AdministradorLineasController()
        {

        }

        public AdministradorLineasController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get()
        {
            var AdministradorLinea = _unityOfWork.AdministradorLinea.GetAll()


            if (AdministradorLinea == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var AdministradorLineasDTO = new List<AdministradorLineaDTO>();

                foreach (var administradorLinea in AdministradorLinea)
                AdministradorLineasDTO.Add(Mapper.Map<AdministradorLinea, AdministradorLineaDTO>(AdministradorLineas));


            return Ok(AdministradorLineasDTO);
        }

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int Id)
        {
            var administradorLinea = _unityOfWork.AdministradorLinea.Get(Id);

            if (administradorLinea == null)
                return NotFound();

            return Ok(Mapper.Map<AdministradorLinea,AdministradorLineaDTO>(administradorLinea));
        }

        // POST api/<controller>
        public voId Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public voId Put(int Id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public voId Delete(int Id)
        {
        }
    }
}