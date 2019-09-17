using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abpVue.Configuration;
using abpVue.Web;

namespace abpVue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class abpVueDbContextFactory : IDesignTimeDbContextFactory<abpVueDbContext>
    {
        public abpVueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<abpVueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            abpVueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(abpVueConsts.ConnectionStringName));

            return new abpVueDbContext(builder.Options);
        }
    }
}
