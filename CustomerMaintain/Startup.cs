using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerMaintain.Startup))]
namespace CustomerMaintain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
