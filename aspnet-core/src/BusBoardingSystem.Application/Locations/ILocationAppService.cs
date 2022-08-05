using Abp.Application.Services;
using BusBoardingSystem.Locations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Locations
{
    public interface ILocationAppService : IAsyncCrudAppService<LocationDto, int, PagedLocationResultRequestDto, CreateLocationDto, LocationDto>
    {
    }
}
