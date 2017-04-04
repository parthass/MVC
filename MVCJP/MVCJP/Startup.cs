using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCJP.Startup))]
namespace MVCJP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
