using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;
using System;

namespace BusBoardingSystem.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class CreateStudentDto : EntityDto<int>
    {
        public int PersonId { get; set; }

        public string StudentNumber { get; set; }

        public Person Person { get; set; }
    }
}
