using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carbon.Startup))]
namespace carbon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
