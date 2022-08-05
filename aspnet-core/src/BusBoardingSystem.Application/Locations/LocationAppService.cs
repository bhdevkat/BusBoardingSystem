using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using BusBoardingSystem.Authorization;
using BusBoardingSystem.Domain;
using BusBoardingSystem.Locations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Locations
{
    [AbpAuthorize(PermissionNames.Pages_Locations)]
    public class LocationAppService : AsyncCrudAppService<Location, LocationDto, int, PagedLocationResultRequestDto, CreateLocationDto, LocationDto>, ILocationAppService
    {  
        public LocationAppService(IRepository<Location, int> repository) : base(repository)
        {
        }
    }
}
