using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(家計簿試作品.Startup))]
namespace 家計簿試作品
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
