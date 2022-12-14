using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace BusBoardingSystem.Domain
{
    public class Person : FullAuditedEntity<int>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string IdNumber { get; set; }
    }
}
