using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Location.Dto
{
    [AutoMapFrom(typeof(Location))]
    public class LocationDto : EntityDto<int>
    {

    }
}
