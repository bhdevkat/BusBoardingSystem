using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoardingSystem.Locations.Dto
{
    [AutoMapFrom(typeof(Location))]
    public class CreateLocationDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Logitude { get; set; }
        public string Latidute { get; set; }
    }
}
