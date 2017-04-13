using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5簡易留言版.Startup))]
namespace MVC5簡易留言版
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
