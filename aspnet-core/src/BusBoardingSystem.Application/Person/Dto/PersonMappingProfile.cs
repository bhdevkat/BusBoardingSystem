using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Person.Dto
{
    public class PersonMappingProfile : Profile
    {
        CreateMap<PersonDto, Person>();

        CreateMap<CreatePersonDto, Person>();
    }
}
