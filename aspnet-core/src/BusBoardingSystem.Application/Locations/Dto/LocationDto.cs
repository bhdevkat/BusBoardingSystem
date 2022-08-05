using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Locations.Dto
{
    [AutoMapFrom(typeof(Location))]
    public class LocationDto : EntityDto<int>
    {

    }
}
