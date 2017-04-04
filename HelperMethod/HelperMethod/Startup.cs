using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelperMethod.Startup))]
namespace HelperMethod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
