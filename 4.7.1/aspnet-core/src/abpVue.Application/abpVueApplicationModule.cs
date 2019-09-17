using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpVue.Authorization;

namespace abpVue
{
    [DependsOn(
        typeof(abpVueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class abpVueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<abpVueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(abpVueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
