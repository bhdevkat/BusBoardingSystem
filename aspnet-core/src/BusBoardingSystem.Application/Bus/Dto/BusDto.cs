using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Bus.Dto
{
    [AutoMapFrom(typeof(Bus))]
    public class BusDto : EntityDto<int>
    {

    }
}
