using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vibes.Web.Startup))]
namespace Vibes.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
