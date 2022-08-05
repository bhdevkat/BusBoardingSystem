using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Location
{
    class interface ILocationAppService : IAsyncCrudAppService<LocationDto, int, PagedLocationResultRequestDto, CreateLocationDto, LocationDto>
    {
    }
}
