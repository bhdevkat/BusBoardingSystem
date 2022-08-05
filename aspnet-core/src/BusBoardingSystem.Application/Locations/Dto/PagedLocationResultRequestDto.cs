using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Locations.Dto
{
    public class PagedLocationResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
