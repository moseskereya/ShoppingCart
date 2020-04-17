using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeShop.Startup))]
namespace RecipeShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
