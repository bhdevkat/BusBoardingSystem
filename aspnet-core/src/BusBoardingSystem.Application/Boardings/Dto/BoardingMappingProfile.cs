using AutoMapper;
using BusBoardingSystem.Domain;
using System;

namespace BusBoardingSystem.Boardings.Dto
{
    public class BoardingMappingProfile : Profile
    {
        public BoardingMappingProfile()
        {
            CreateMap<BoardingDto, Boarding>();

            CreateMap<CreateBoardingDto, Boarding>();
        }
    }
}
