using AutoMapper;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.Students.Dto
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<StudentDto, Student>();

            CreateMap<Student, StudentDto>()
                .ForMember(r => r.PersonName, opt => opt.MapFrom(e => e.Person.Name))
                ;

            CreateMap<CreateStudentDto, Student>()
                .ForPath(r => r.Person, opt => opt.Ignore())
                ;
        }
    }
}
