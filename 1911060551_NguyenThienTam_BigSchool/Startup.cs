using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911060551_NguyenThienTam_BigSchool.Startup))]
namespace _1911060551_NguyenThienTam_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
