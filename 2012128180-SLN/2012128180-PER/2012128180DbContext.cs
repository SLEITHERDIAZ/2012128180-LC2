using _2012128180_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER
{
    public class _2012128180DbContext : DbContext
    {
        public DbSet<AdministradorEquipo> AdministradorEquipo { get; set; }
        public DbSet<AdministradorLinea> AdministradorLinea { get; set; }
        public DbSet<CentroAtencion> CentroAtencion { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Departamento> Departameto { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<EquipoCelular> EquipoCelular { get; set; }
        public DbSet<EstadoEvaluacion> EstadoEvaluacion { get; set; }
        public DbSet<Evaluacion> Evaluacion { get; set; }
        public DbSet<LineaTelefonica> LineaTelefonica { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<TipoEvaluacion> TipoEvaluacion { get; set; }
        public DbSet<TipoLinea> TipoLinea { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }
        public DbSet<TipoPlan> TipoPlan { get; set; }
        public DbSet<TipoTrabajador> TipoTrabajador { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Ubigeo> Ubigeo { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
    }
}
