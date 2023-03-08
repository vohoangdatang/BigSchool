using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoHoangDat_1811060166.Startup))]
namespace VoHoangDat_1811060166
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
