using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp472.Startup))]
namespace WebApp472
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
