using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using BusBoardingSystem.Authorization;
using BusBoardingSystem.Domain;
using BusBoardingSystem.Students.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusBoardingSystem.Students
{
    [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>, IStudentAppService
    {  
        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
        }

        public override async Task<StudentDto> GetAsync(EntityDto<int> input)
        {
            var singleJobCard = await Repository
                            .GetAllIncluding(x => x.Person
                                ).SingleOrDefaultAsync(x => x.Id == input.Id);

            return ObjectMapper.Map<StudentDto>(singleJobCard);
        }

        public override async Task<PagedResultDto<StudentDto>> GetAllAsync(PagedStudentResultRequestDto input)
        {
            List<Student> students = await Repository
                            .GetAllIncluding(x => x.Person
                                 ).ToListAsync();

            var entity = ObjectMapper.Map<List<StudentDto>>(students);

            var results = new PagedResultDto<StudentDto>()
            {
                Items = entity,
                TotalCount = entity.Count
            };

            return results;
        }
    }
}
