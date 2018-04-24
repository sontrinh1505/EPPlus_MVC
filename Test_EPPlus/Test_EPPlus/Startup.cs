using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_EPPlus.Startup))]
namespace Test_EPPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
