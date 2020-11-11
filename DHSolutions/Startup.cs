using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DHSolutions.Startup))]
namespace DHSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
