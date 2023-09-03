using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibraryApp.Configuration.Dto;

namespace LibraryApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibraryAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
