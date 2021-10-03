using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ASP_WebApp.Startup))]
namespace MVC_ASP_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
