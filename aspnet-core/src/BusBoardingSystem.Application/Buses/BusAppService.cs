using Abp.Application.Services;
using Abp.Domain.Repositories;

using Abp.Authorization;
using BusBoardingSystem.Authorization;
using BusBoardingSystem.Domain;
using BusBoardingSystem.Buses.Dto;


namespace BusBoardingSystem.Buses
{
    [AbpAuthorize(PermissionNames.Pages_Buses)]
    public class BusAppService : AsyncCrudAppService<Bus, BusDto, int, PagedBusResultRequestDto, CreateBusDto, BusDto>, IBusAppService
    {   
        public BusAppService(IRepository<Bus, int> repository) : base(repository)
        {
        }
    }
}
