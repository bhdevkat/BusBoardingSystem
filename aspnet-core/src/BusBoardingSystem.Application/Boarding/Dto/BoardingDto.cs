using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boarding.Dto
{
    [AutoMapFrom(typeof(Boarding))]
    public class BoardingDto : EntityDto<int>
    {

    }
}
