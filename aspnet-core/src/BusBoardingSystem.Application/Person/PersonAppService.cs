using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Person
{
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>, IPersonAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Person)]
        public PersonAppService(IRepository<Person, int> repository) : base(repository)
        {
        }
    }
}
