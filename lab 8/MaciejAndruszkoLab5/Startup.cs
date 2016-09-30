using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaciejAndruszkoLab5.Startup))]
namespace MaciejAndruszkoLab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
