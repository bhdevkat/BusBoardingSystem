using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Staff.Dto
{
    public class StaffMappingProfile : Profile
    {
        CreateMap<StaffDto, Staff>();

        CreateMap<CreateStaffDto, Staff>();
    }
}
