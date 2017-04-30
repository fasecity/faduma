using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fadum.Startup))]
namespace fadum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
