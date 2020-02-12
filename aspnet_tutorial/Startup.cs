using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_tutorial.Startup))]
namespace aspnet_tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
