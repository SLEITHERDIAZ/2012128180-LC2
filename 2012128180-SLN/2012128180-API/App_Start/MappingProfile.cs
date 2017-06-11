using _2012128180_API.DTO;
using _2012128180_EN.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace _2012128180_API.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<AdministradorEquipo, AdministradorEquipoDTO>();
            CreateMap<AdministradorEquipoDTO, AdministradorEquipo>();

            CreateMap<AdministradorLinea, AdministradorLineaDTO>();
            CreateMap<AdministradorLineaDTO, AdministradorLinea>();

            CreateMap<CentroAtencion, CentroAtencionDTO>();
            CreateMap<CentroAtencionDTO, CentroAtencion>();

            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Contrato, ContratoDTO>();
            CreateMap<ContratoDTO, Contrato>();

            CreateMap<Departamento,DepartamentoDTO>();
            CreateMap<DepartamentoDTO, Departamento>();

            CreateMap<Direccion, DireccionDTOcs>();
            CreateMap<DireccionDTOcs, Direccion>();

            CreateMap<EquipoCelular, EquipoCelularDTO>();
            CreateMap<EquipoCelularDTO, EquipoCelular>();

            CreateMap<EstadoEvaluacion, EstadoEvaluacionDTO>();
            CreateMap<EstadoEvaluacionDTO, EstadoEvaluacion>();

            CreateMap<Evaluacion, EvaluacionDTO>();
            CreateMap<EvaluacionDTO, Evaluacion>();

            CreateMap<LineaTelefonica, LineaTelefonicaDTO>();
            CreateMap<LineaTelefonicaDTO, LineaTelefonica>();

            CreateMap<Plan, PlanDTO>();
            CreateMap<PlanDTO, Plan>();

            CreateMap<Provincia, ProvinciaDTO>();
            CreateMap<ProvinciaDTO, Provincia>();

            CreateMap<TipoEvaluacion, TipoEvaluacionDTO>();
            CreateMap<TipoEvaluacionDTO, TipoEvaluacion>();

            CreateMap<TipoLinea, TipoLineaDTO>();
            CreateMap<TipoLineaDTO, TipoLinea>();

            CreateMap<TipoPago, TipoPagoDTO>();
            CreateMap<TipoPagoDTO, TipoPago>();

            CreateMap<TipoPlan, TipoPlanDTO>();
            CreateMap<TipoPlanDTO, TipoPlan>();

            CreateMap<TipoPago, TipoPagoDTO>();
            CreateMap<TipoPagoDTO, TipoPago>();

            CreateMap<TipoPlan, TipoPlanDTO>();
            CreateMap<TipoPlanDTO, TipoPlan>();

            CreateMap<TipoTrabajador, TipoTrabajadorDTO>();
            CreateMap<TipoTrabajadorDTO, TipoTrabajador>();

            CreateMap<Trabajador, TrabajadorDTO>();
            CreateMap<TrabajadorDTO, Trabajador>();

            CreateMap<Ventas, VentasDTO>();
            CreateMap<VentasDTO, Ventas>();

       

        
        }

        protected override void Configure()
        {
            throw new NotImplementedException();
        }
    }
}