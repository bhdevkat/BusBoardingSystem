using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using BusBoardingSystem.Authorization;
using BusBoardingSystem.Domain;
using BusBoardingSystem.People.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.People
{
    [AbpAuthorize(PermissionNames.Pages_People)]
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>, IPersonAppService
    {            
        public PersonAppService(IRepository<Person, int> repository) : base(repository)
        {
        }
    }
}
