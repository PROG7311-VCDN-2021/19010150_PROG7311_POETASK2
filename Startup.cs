using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACMEINCStore.Startup))]
namespace ACMEINCStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
