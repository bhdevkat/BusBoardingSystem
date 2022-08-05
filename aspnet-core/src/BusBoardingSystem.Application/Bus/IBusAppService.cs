using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Bus
{
    class interface IBusAppService : IAsyncCrudAppService<BusDto, int, PagedBusResultRequestDto, CreateBusDto, BusDto>
    {
    }
}
