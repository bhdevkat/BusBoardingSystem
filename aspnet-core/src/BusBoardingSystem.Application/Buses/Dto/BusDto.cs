using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Buses.Dto
{
    [AutoMapFrom(typeof(Bus))]
    public class BusDto : EntityDto<int>
    {

    }
}
