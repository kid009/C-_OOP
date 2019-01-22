using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWF.Startup))]
namespace ProjectWF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
