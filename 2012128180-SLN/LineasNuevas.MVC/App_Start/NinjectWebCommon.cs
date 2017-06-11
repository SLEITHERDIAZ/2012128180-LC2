[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LineasNuevas.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LineasNuevas.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace LineasNuevas.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using _2012128180_PER.Persistence;
    using _2012128180_PER.Persistence.Repositories;
    using _2012128180_EN.Entities.IRepositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<JeffdiazDbContext>().To<JeffdiazDbContext>();

            kernel.Bind<IAdministradorEquipoRepository>().To<AdministradorEquipoRepository>();
            kernel.Bind<IAdministradorLineaRepository>().To<AdministradorLineaRepository>();
            kernel.Bind<ICentroAtencionRepository>().To<CentroAtencionRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IContratoRepository>().To<ContratoRepository>();
            kernel.Bind<IDepartamentoRepository>().To<DepartamentoRepository>();
            kernel.Bind<IDireccionRepository>().To<DireccionRepository>();
            kernel.Bind<IDistritoRepository>().To<DistritoRepository>();
            kernel.Bind<IEquipoCelularRepository>().To<EquipoCelularRepository>();
            kernel.Bind<IEstadoEvaluacionRepository>().To<EstadoEvaluacionRepository>();
            kernel.Bind<IEvaluacionRepository>().To<EvaluacionRepository>();
            kernel.Bind<ILineaTelefonicaRepository>().To<LineaTelefonicaRepository>();
            kernel.Bind<IPlanRepository>().To<PlanRepository>();
            kernel.Bind<IProvinciaRepository>().To<ProvinciaRepository>();
            kernel.Bind<ITipoEvaluacionRepository>().To<TipoEvaluacionRepository>();
            kernel.Bind<ITipoLineaRepository>().To<TipoLineaRepository>();
            kernel.Bind<ITipoPagoRepository>().To<TipoPagoRepository>();
            kernel.Bind<ITipoPlanRepository>().To<TipoPlanRepository>();
            kernel.Bind<ITipoTrabajadorRepository>().To<TipoTrabajadorRepository>();
            kernel.Bind<ITrabajadorRepository>().To<TrabajadorRepository>();
            kernel.Bind<IVentasRepository>().To<VentasRepository>();

        }        
    }
}
