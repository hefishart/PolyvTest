using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Polyv01.Startup))]
namespace Polyv01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
