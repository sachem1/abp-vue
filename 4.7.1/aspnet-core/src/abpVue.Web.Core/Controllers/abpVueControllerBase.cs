using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abpVue.Controllers
{
    public abstract class abpVueControllerBase: AbpController
    {
        protected abpVueControllerBase()
        {
            LocalizationSourceName = abpVueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
