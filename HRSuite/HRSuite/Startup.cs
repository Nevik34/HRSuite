using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRSuite.Startup))]
namespace HRSuite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
