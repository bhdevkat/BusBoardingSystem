using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Location.Dto
{
    public class PagedLocationRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
