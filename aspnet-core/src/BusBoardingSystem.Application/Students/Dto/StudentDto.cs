using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;
using System;

namespace BusBoardingSystem.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class StudentDto : EntityDto<int>
    {
        public int PersonId { get; set; }

        public string PersonName { get; set; }

        public string StudentNumber { get; set; }
    }
}
