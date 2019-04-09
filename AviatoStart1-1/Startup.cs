using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AviatoStart1_1.Startup))]
namespace AviatoStart1_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
