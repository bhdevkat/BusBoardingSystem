using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Bus
{
    public class BusAppService : AsyncCrudAppService<Bus, BusDto, int, PagedBusResultRequestDto, CreateBusDto, BusDto>, IBusAppService
    {    
        [AbpAuthorize(PermissionNames.Pages_Bus)]
        public BusAppService(IRepository<Bus, int> repository) : base(repository)
        {
        }
    }
}
