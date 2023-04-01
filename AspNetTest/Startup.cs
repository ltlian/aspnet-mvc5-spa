using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetTest.Startup))]
namespace AspNetTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
