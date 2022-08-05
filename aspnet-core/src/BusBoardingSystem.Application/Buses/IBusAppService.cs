using Abp.Application.Services;
using BusBoardingSystem.Buses.Dto;

namespace BusBoardingSystem.Buses
{
    public interface IBusAppService : IAsyncCrudAppService<BusDto, int, PagedBusResultRequestDto, CreateBusDto, BusDto>
    {
    }
}
