using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Person.Dto
{
    public class PagedPersonRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
