using ClotheManagementSystem.Filters;
using System.Web.Mvc;

namespace ClotheManagementSystem.Controllers
{
    [AdminAuthorize]

    public class SettingsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}