using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VartasFront1.Startup))]
namespace VartasFront1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
