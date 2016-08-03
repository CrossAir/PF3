using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealerProyect.Startup))]
namespace DealerProyect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
