using System.Web.Mvc;
using ClotheManagementSystem.Models;

namespace ClotheManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();

            // Temporary Dummy Data
            // SQL aane ke baad sirf ye values database se aayengi

            model.TotalProducts = 0;
            model.TotalCategories = 0;
            model.LowStockProducts = 0;
            model.TotalRevenue = 0;

            // RecentProducts list abhi empty rahegi

            return View(model);
        }
    }
}