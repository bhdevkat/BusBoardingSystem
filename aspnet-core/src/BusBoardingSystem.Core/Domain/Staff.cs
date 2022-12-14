using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace BusBoardingSystem.Domain
{
    public class Staff : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public int PersonId { get; set; }
        public string StaffNumber { get; set; }
    }
}
