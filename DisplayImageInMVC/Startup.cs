using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DisplayImageInMVC.Startup))]
namespace DisplayImageInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
