using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Person
{
    class interface IPersonAppService : IAsyncCrudAppService<PersonDto, int, PagedPersonResultRequestDto, CreatePersonDto, PersonDto>
    {
    }
}
