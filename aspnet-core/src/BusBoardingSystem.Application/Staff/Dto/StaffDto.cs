using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Staff.Dto
{
    [AutoMapFrom(typeof(Staff))]
    public class StaffDto : EntityDto<int>
    {

    }
}
