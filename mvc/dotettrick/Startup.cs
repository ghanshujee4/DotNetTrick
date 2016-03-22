using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotettrick.Startup))]
namespace dotettrick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
