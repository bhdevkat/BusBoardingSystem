using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BusBoardingSystem.Authorization;

namespace BusBoardingSystem
{
    [DependsOn(
        typeof(BusBoardingSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BusBoardingSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BusBoardingSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BusBoardingSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
