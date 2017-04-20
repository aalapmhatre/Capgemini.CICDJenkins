using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capgemini.CICDJenkins.WebApp.Startup))]
namespace Capgemini.CICDJenkins.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
