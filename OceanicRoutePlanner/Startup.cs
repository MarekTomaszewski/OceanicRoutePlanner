using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OceanicRoutePlanner.Startup))]
namespace OceanicRoutePlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
