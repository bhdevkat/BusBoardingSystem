using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Bus.Dto
{
    public class PagedBusRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
