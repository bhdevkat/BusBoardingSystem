using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Trip
{
    public class TripAppService : AsyncCrudAppService<Trip, TripDto, int, PagedTripResultRequestDto, CreateTripDto, TripDto>, ITripAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Trip)]
        public TripAppService(IRepository<Trip, int> repository) : base(repository)
        {
        }
    }
}
