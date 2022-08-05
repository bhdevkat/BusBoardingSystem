using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Staff
{
    class interface IStaffAppService : IAsyncCrudAppService<StaffDto, int, PagedStaffResultRequestDto, CreateStaffDto, StaffDto>
    {
    }
}
