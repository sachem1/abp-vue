using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpVue.Configuration;

namespace abpVue.Web.Host.Startup
{
    [DependsOn(
       typeof(abpVueWebCoreModule))]
    public class abpVueWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abpVueWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abpVueWebHostModule).GetAssembly());
        }
    }
}
