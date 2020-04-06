using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LillysBeauty.Startup))]
namespace LillysBeauty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
