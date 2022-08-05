using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace BusBoardingSystem.Domain
{
    public class Trip : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public int ScheduleId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }
    }
}
