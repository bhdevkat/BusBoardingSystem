using Abp.Application.Services;
using BusBoardingSystem.Students.Dto;

namespace BusBoardingSystem.Students
{
    public  interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
    }
}
