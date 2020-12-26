using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPS.Startup))]
namespace CPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
