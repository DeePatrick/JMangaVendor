using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMangaVendor.Startup))]
namespace JMangaVendor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
