using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BusBoardingSystem.Domain;
using System;

namespace BusBoardingSystem.Trips.Dto
{
    [AutoMapFrom(typeof(Trip))]
    public class TripDto : EntityDto<int>
    {
        public int ScheduleId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }
    }
}
