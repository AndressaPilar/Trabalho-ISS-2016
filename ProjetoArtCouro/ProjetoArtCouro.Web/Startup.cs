using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoArtCouro.Web.Startup))]
namespace ProjetoArtCouro.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
