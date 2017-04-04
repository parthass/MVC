using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_starter.Startup))]
namespace MVC_starter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
