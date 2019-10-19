using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthLogin.Startup))]
namespace AuthLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
