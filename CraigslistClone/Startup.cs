using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CraigslistClone.Startup))]
namespace CraigslistClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
