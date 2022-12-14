using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace BusBoardingSystem.Domain
{
    public class Location : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Logitude { get; set; }
        public string Latidute { get; set; }
    }
}
