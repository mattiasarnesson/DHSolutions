using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DHSolutionsWeb.Startup))]
namespace DHSolutionsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
