using Abp.Application.Services;
using BusBoardingSystem.MyStaff.Dto;

namespace BusBoardingSystem.MyStaff
{
    public interface IStaffAppService : IAsyncCrudAppService<StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, StaffDto>
    {
    }
}
