using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITB7334Assignment2.Startup))]
namespace ITB7334Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
