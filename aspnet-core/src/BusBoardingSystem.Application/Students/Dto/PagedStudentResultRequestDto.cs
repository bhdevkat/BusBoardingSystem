using Abp.Application.Services.Dto;

namespace BusBoardingSystem.Students.Dto
{
    public class PagedStudentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
