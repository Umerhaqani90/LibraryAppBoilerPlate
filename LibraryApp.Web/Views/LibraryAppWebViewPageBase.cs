using Abp.Web.Mvc.Views;

namespace LibraryApp.Web.Views
{
    public abstract class LibraryAppWebViewPageBase : LibraryAppWebViewPageBase<dynamic>
    {

    }

    public abstract class LibraryAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LibraryAppWebViewPageBase()
        {
            LocalizationSourceName = LibraryAppConsts.LocalizationSourceName;
        }
    }
}