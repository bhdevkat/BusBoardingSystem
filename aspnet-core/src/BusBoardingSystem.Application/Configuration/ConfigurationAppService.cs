using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BusBoardingSystem.Configuration.Dto;

namespace BusBoardingSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BusBoardingSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
