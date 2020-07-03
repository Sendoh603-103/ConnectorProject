using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectorProject.Startup))]
namespace ConnectorProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
