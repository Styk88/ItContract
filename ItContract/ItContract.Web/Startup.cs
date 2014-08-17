using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItContract.Web.Startup))]
namespace ItContract.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
