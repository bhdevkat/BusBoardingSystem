using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BusBoardingSystem.EntityFrameworkCore
{
    public static class BusBoardingSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BusBoardingSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BusBoardingSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
