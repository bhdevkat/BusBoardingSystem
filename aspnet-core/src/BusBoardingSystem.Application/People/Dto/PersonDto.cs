using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;
using System;

namespace BusBoardingSystem.People.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string IdNumber { get; set; }
    }
}
