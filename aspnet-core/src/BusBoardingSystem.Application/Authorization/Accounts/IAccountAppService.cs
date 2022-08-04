using System.Threading.Tasks;
using Abp.Application.Services;
using BusBoardingSystem.Authorization.Accounts.Dto;

namespace BusBoardingSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
