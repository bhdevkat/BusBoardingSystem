using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Trip
{
    class interface ITripAppService : IAsyncCrudAppService<TripDto, int, PagedTripResultRequestDto, CreateTripDto, TripDto>
    {
    }
}
