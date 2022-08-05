using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boardings.Dto
{
    public class PagedBoardingResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
