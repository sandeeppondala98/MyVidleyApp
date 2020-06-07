using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVidleyApp.Startup))]
namespace MyVidleyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
