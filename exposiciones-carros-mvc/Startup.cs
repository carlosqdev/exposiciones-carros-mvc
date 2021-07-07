using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(exposiciones_carros_mvc.Startup))]
namespace exposiciones_carros_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
