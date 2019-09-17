using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abpVue.Authorization.Roles;
using abpVue.Authorization.Users;
using abpVue.MultiTenancy;

namespace abpVue.EntityFrameworkCore
{
    public class abpVueDbContext : AbpZeroDbContext<Tenant, Role, User, abpVueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public abpVueDbContext(DbContextOptions<abpVueDbContext> options)
            : base(options)
        {
        }
    }
}
