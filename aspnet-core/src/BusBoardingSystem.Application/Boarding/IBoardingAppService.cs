using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boarding
{
    class interface IBoardingAppService : IAsyncCrudAppService<BoardingDto, int, PagedBoardingResultRequestDto, CreateBoardingDto, BoardingDto>
    {
    }
}
