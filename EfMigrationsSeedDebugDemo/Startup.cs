using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EfMigrationsSeedDebugDemo.Startup))]
namespace EfMigrationsSeedDebugDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
