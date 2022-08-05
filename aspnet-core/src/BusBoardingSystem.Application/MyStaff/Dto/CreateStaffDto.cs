using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.MyStaff.Dto
{
    [AutoMapFrom(typeof(Staff))]
    public class CreateStaffDto : EntityDto<int>
    {

    }
}
