using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rdvMedecinMvc.Startup))]
namespace rdvMedecinMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
