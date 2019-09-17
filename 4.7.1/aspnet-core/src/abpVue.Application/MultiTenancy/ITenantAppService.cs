using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abpVue.MultiTenancy.Dto;

namespace abpVue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

