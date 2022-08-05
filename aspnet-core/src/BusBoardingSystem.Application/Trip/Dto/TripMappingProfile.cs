using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Trip.Dto
{
    public class TripMappingProfile : Profile
    {
        CreateMap<TripDto, Trip>();

        CreateMap<CreateTripDto, Trip>();
    }
}
