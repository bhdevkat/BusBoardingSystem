using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Trips.Dto
{
    [AutoMapFrom(typeof(Trip))]
    public class CreateTripDto : EntityDto<int>
    {

    }
}
