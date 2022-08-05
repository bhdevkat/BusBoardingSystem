using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Staff
{
    public class StaffAppService : AsyncCrudAppService<Staff, StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, StaffDto>, IStaffAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Staff)]
        public StaffAppService(IRepository<Staff, int> repository) : base(repository)
        {
        }
    }
}
