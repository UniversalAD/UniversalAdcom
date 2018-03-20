using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversalAdcom.Startup))]
namespace UniversalAdcom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
