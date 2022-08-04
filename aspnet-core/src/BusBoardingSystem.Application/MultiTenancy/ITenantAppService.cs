using Abp.Application.Services;
using BusBoardingSystem.MultiTenancy.Dto;

namespace BusBoardingSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

