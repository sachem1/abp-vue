using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abpVue.Configuration.Dto;

namespace abpVue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : abpVueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
