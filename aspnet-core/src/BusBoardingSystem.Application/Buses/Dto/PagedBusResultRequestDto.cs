using Abp.Application.Services.Dto;

namespace BusBoardingSystem.Buses.Dto
{
    public class PagedBusResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
