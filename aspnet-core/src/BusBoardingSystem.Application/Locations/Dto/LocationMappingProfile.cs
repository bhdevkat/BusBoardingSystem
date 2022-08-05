using AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Locations.Dto
{
    public class LocationMappingProfile : Profile
    {
        public LocationMappingProfile()
        {
            CreateMap<LocationDto, Location>();

            CreateMap<CreateLocationDto, Location>();
        }
    }
}
