using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VartasBackend1.Startup))]
namespace VartasBackend1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
