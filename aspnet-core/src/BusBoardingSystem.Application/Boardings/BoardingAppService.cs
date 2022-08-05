using BusBoardingSystem.Authorization;
using BusBoardingSystem.Boardings.Dto;
using BusBoardingSystem.Domain;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusBoardingSystem.Boardings
{
    [AbpAuthorize(PermissionNames.Pages_Boardings)]
    public class BoardingAppService : AsyncCrudAppService<Boarding, BoardingDto, int, PagedBoardingResultRequestDto, CreateBoardingDto, BoardingDto>, IBoardingAppService
    {           
        public BoardingAppService(IRepository<Boarding, int> repository) : base(repository)
        {
        }
    }
}
