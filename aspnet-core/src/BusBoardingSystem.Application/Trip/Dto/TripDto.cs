using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Trip.Dto
{
    [AutoMapFrom(typeof(Trip))]
    public class TripDto : EntityDto<int>
    {

    }
}
