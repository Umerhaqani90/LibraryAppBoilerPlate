using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryApp.Configuration.Dto;

namespace LibraryApp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}