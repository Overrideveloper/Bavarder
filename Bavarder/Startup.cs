using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bavarder.Startup))]  
namespace Bavarder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
