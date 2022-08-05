using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BusBoardingSystem.Boardings.Dto;

namespace BusBoardingSystem.Boardings
{
    public interface IBoardingAppService : IAsyncCrudAppService<BoardingDto, int, PagedBoardingResultRequestDto, CreateBoardingDto, BoardingDto>
    {
    }
}
