using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.MyStaff.Dto
{
    [AutoMapFrom(typeof(Staff))]
    public class StaffDto : EntityDto<int>
    {
        public int PersonId { get; set; }
        public string StaffNumber { get; set; }
    }
}
