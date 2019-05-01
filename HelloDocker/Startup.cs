using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloDocker.Startup))]
namespace HelloDocker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
