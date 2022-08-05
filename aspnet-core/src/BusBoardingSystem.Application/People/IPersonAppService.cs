using Abp.Application.Services;
using BusBoardingSystem.People.Dto;

namespace BusBoardingSystem.People
{
    public interface IPersonAppService : IAsyncCrudAppService<PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>
    {
    }
}
