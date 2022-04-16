using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dextar.Startup))]
namespace Dextar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
