using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BusBoardingSystem.EntityFrameworkCore;
using BusBoardingSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BusBoardingSystem.Web.Tests
{
    [DependsOn(
        typeof(BusBoardingSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BusBoardingSystemWebTestModule : AbpModule
    {
        public BusBoardingSystemWebTestModule(BusBoardingSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BusBoardingSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BusBoardingSystemWebMvcModule).Assembly);
        }
    }
}