using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.People.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class CreatePersonDto : EntityDto<int>
    {

    }
}
