using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryApp.MultiTenancy.Dto;

namespace LibraryApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
