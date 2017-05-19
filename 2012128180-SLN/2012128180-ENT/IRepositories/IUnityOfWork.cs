using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_EN.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministradorEquipoRepository AdministradorEquipo { get; }
        IAdministradorLineaRepository AdministradorLinea{ get; }
        ICentroAtencionRepository CentroAtencion { get; }
        IContratoRepository Contrato { get; }
        IDepartamentoRepository Departamento { get; }
        IDireccionRepository Direccion { get; }
        IDistritoRepository Distrito { get; }
        IEquipoCelularRepository EquipoCelular { get; }
        IEstadoEvaluacionRepository EstadoEvaluacion { get; }
        IEvaluacionRepository Evaluacion { get; }
        ILineaTelefonicaRepository LineaTelefonica { get; }
        IPlanRepository Plan { get; }
        IProvinciaRepository Provincia { get; }
        ITipoEvaluacionRepository TipoEvaluacion { get; }
        ITipoLineaRepository TipoLinea { get; }
        ITipoPagoRepository TipoPago { get; }
        ITipoPlanRepository TipoPlan { get; }
        ITipoTrabajadorRepository TipoTrabajador { get; }
        ITrabajadorRepository Trabajador { get; }
        IUbigeoRepository Ubigeo { get; }
        IVentasRepository Ventas { get; }

        int SaveChanges();

    }
}

