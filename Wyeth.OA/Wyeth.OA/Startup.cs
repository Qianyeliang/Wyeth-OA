using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wyeth.OA.Startup))]
namespace Wyeth.OA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
