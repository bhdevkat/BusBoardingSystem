using AutoMapper;
using BusBoardingSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Buses.Dto
{
    public class BusMappingProfile : Profile
    {
        public BusMappingProfile()
        {
            CreateMap<BusDto, Bus>();

            CreateMap<CreateBusDto, Bus>();
        }
    }
}
