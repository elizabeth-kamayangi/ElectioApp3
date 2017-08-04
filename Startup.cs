using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectionApp3.Startup))]
namespace ElectionApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
