using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using BusBoardingSystem.Authorization;
using BusBoardingSystem.Domain;
using BusBoardingSystem.MyStaff.Dto;

namespace BusBoardingSystem.MyStaff
{
    [AbpAuthorize(PermissionNames.Pages_Staff)]
    public class StaffAppService : AsyncCrudAppService<Staff, StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, StaffDto>, IStaffAppService
    {   
        public StaffAppService(IRepository<Staff, int> repository) : base(repository)
        {
        }
    }
}
