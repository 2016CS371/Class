using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassManagment.Startup))]
namespace ClassManagment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
