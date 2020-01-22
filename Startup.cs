using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DF984515MIS4200.Startup))]
namespace DF984515MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
