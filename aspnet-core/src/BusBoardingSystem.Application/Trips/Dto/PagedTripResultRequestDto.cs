using Abp.Application.Services.Dto;

namespace BusBoardingSystem.Trips.Dto
{
    public class PagedTripResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
