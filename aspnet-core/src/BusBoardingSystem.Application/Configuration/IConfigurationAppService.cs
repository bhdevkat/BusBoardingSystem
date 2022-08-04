using System.Threading.Tasks;
using BusBoardingSystem.Configuration.Dto;

namespace BusBoardingSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
