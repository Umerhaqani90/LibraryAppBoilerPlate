using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Sessions.Dto;

namespace LibraryApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
