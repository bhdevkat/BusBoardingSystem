using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Boardings.Dto
{
    [AutoMapFrom(typeof(Boarding))]
    public class BoardingDto : EntityDto<int>
    {

    }
}
