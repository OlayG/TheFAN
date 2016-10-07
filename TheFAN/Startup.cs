using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheFAN.Startup))]
namespace TheFAN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
