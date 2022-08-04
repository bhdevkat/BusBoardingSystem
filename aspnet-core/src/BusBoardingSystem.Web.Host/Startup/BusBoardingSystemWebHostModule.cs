using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BusBoardingSystem.Configuration;

namespace BusBoardingSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(BusBoardingSystemWebCoreModule))]
    public class BusBoardingSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BusBoardingSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BusBoardingSystemWebHostModule).GetAssembly());
        }
    }
}
