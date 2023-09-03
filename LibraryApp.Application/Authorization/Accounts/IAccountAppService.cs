using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Authorization.Accounts.Dto;

namespace LibraryApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
