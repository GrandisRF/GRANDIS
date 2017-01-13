using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRANDIS.Startup))]
namespace GRANDIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
