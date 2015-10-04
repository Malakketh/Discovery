using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Discovery.Startup))]
namespace Discovery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
