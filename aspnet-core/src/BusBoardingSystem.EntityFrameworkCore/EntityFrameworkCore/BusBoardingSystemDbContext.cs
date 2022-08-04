using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BusBoardingSystem.Authorization.Roles;
using BusBoardingSystem.Authorization.Users;
using BusBoardingSystem.MultiTenancy;

namespace BusBoardingSystem.EntityFrameworkCore
{
    public class BusBoardingSystemDbContext : AbpZeroDbContext<Tenant, Role, User, BusBoardingSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BusBoardingSystemDbContext(DbContextOptions<BusBoardingSystemDbContext> options)
            : base(options)
        {
        }
    }
}
