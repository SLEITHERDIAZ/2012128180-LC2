using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class UnityOfWork:IUnityOfWork
    {
        private readonly JeffdiazDbContext _Context;

        public IAdministradorEquipoRepository AdministradorEquipo { get; private set; }
        public IAdministradorLineaRepository AdministradorLinea { get; private set; }
        public ICentroAtencionRepository CentroAtencion { get; private set; }
        public IClienteRepository Cliente { get; private set; }
        public IContratoRepository Contrato { get; private set; }
        public IDepartamentoRepository Departamento { get; private set; }
        public IDireccionRepository Direccion { get; private set; }
        public IDistritoRepository Distrito { get; private set; }
        public IEquipoCelularRepository EquipoCelular { get; private set; }
        public IEstadoEvaluacionRepository EstadoEvaluacion { get; private set; }
        public IEvaluacionRepository Evaluacion { get; private set; }
        public ILineaTelefonicaRepository LineaTelefonica { get; private set; }
        public IPlanRepository Plan { get; private set; }
        public IProvinciaRepository Provincia { get; private set; }
        public ITipoEvaluacionRepository TipoEvaluacion { get; private set; }
        public ITipoLineaRepository TipoLinea { get; private set; }
        public ITipoPagoRepository TipoPago { get; private set; }
        public ITipoPlanRepository TipoPlan { get; private set; }
        public ITipoTrabajadorRepository TipoTrabajador { get; private set; }
        public ITrabajadorRepository Trabajador { get; private set; }
        public IVentasRepository Ventas { get; private set; }

        public UnityOfWork()
        {

        }

        public UnityOfWork(JeffdiazDbContext JeffdiazDbContext)
        {
            _Context = new JeffdiazDbContext();

            AdministradorEquipo = new AdministradorEquipoRepository(_Context);
            AdministradorLinea = new AdministradorLineaRepository(_Context);
            CentroAtencion = new CentroAtencionRepository(_Context);
            Cliente = new ClienteRepository(_Context);
            Contrato = new ContratoRepository(_Context);
            Departamento = new DepartamentoRepository(_Context);
            Direccion = new DireccionRepository(_Context);
            Distrito=new DistritoRepository(_Context);
            EquipoCelular = new EquipoCelularRepository(_Context);
            EstadoEvaluacion = new EstadoEvaluacionRepository(_Context);
            Evaluacion = new EvaluacionRepository(_Context);
            LineaTelefonica = new LineaTelefonicaRepository(_Context);
            Plan=new PlanRepository(_Context);
            Provincia=new ProvinciaRepository(_Context);
            TipoEvaluacion=new TipoEvaluacionRepository(_Context);
            TipoLinea=new TipoLineaRepository(_Context);
            TipoPago=new TipoPagoRepository(_Context);
            TipoPlan=new TipoPlanRepository(_Context);
            TipoTrabajador=new TipoTrabajadorRepository(_Context);
            Trabajador=new TrabajadorRepository(_Context);
            Ventas=new VentasRepository(_Context);




        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
