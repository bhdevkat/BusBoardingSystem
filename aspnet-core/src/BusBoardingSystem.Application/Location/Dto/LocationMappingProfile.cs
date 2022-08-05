using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Location.Dto
{
    public class LocationMappingProfile : Profile
    {
        CreateMap<LocationDto, Location>();

        CreateMap<CreateLocationDto, Location>();
    }
}
