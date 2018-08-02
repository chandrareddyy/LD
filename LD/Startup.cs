using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LD.Startup))]
namespace LD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
