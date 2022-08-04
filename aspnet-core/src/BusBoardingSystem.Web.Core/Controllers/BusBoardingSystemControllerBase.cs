using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BusBoardingSystem.Controllers
{
    public abstract class BusBoardingSystemControllerBase: AbpController
    {
        protected BusBoardingSystemControllerBase()
        {
            LocalizationSourceName = BusBoardingSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
