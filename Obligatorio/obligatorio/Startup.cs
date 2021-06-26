using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(obligatorio.Startup))]
namespace obligatorio
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
