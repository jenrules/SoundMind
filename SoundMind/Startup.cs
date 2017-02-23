using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundMind.Startup))]
namespace SoundMind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
