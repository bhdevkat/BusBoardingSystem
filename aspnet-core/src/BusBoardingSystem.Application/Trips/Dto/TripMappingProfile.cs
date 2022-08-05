using AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Trips.Dto
{
    public class TripMappingProfile : Profile
    {
        public TripMappingProfile()
        {
            CreateMap<TripDto, Trip>();

            CreateMap<CreateTripDto, Trip>();
        }
    }
}
