using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boarding
{
    public class BoardingAppService : AsyncCrudAppService<Boarding, BoardingDto, int, PagedBoardingResultRequestDto, CreateBoardingDto, BoardingDto>, IBoardingAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Boarding)]
        public BoardingAppService(IRepository<Boarding, int> repository) : base(repository)
        {
        }
    }
}
