using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abpVue.EntityFrameworkCore
{
    public static class abpVueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<abpVueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<abpVueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
