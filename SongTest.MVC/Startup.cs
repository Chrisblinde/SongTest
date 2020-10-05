using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SongTest.MVC.Startup))]
namespace SongTest.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
