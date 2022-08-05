using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Domain
{
    public class Trip : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public int ScheduleId { get; set; }

        public DeteTime DepartureTime { get; set; }

        public DeteTime ArrivalTime { get; set; }
    }
}
