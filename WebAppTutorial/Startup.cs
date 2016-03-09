using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTutorial.Startup))]
namespace WebAppTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
