using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GC45.Project.Mvc.Startup))]
namespace GC45.Project.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
