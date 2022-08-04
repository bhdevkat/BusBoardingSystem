using System.Threading.Tasks;
using Abp.Application.Services;
using BusBoardingSystem.Sessions.Dto;

namespace BusBoardingSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
