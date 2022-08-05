using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Person.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonDto : EntityDto<int>
    {

    }
}
