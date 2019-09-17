using System.Threading.Tasks;
using Abp.Application.Services;
using abpVue.Sessions.Dto;

namespace abpVue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
