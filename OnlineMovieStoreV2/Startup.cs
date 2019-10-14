using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineMovieStoreV2.Startup))]
namespace OnlineMovieStoreV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Test Comment
            ConfigureAuth(app);
        }
    }
}
