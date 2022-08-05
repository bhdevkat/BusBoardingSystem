using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.People.Dto
{
    public class PagedPersonResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
