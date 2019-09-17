using System.Threading.Tasks;
using abpVue.Configuration.Dto;

namespace abpVue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
