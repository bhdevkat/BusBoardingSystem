using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BusBoardingSystem.Authorization.Roles;
using BusBoardingSystem.Authorization.Users;
using BusBoardingSystem.MultiTenancy;
using BusBoardingSystem.Domain;

namespace BusBoardingSystem.EntityFrameworkCore
{
    public class BusBoardingSystemDbContext : AbpZeroDbContext<Tenant, Role, User, BusBoardingSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Boarding> Boardings { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public BusBoardingSystemDbContext(DbContextOptions<BusBoardingSystemDbContext> options)
            : base(options)
        {
        }
    }
}
