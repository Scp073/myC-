using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stu201831980117.Startup))]
namespace stu201831980117
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
