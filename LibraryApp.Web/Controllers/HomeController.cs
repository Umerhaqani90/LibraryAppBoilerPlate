using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace LibraryApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LibraryAppControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}