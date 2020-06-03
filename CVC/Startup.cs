using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVC.Startup))]
namespace CVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
