using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteT1.Startup))]
namespace SiteT1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
