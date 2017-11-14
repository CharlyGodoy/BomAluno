using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BomAlunoNew.Startup))]
namespace BomAlunoNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
