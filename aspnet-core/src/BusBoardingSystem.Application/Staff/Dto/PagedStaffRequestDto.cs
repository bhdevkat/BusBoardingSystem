using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Staff.Dto
{
    public class PagedStaffRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
