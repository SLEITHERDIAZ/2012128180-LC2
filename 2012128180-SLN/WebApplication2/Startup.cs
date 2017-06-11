using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LineasNuevas.MVC.Startup))]
namespace LineasNuevas.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
