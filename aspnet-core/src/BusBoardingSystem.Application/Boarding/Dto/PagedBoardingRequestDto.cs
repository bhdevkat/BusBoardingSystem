using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boarding.Dto
{
    public class PagedBoardingRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
