using Abp.Application.Services;
using BusBoardingSystem.Trips.Dto;

namespace BusBoardingSystem.Trips
{
    public  interface ITripAppService : IAsyncCrudAppService<TripDto, int, PagedTripResultRequestDto, CreateTripDto, TripDto>
    {
    }
}
