using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Location
{
    public class LocationAppService : AsyncCrudAppService<Location, LocationDto, int, PagedLocationResultRequestDto, CreateLocationDto, LocationDto>, ILocationAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Location)]
        public LocationAppService(IRepository<Location, int> repository) : base(repository)
        {
        }
    }
}
