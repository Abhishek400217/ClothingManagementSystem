using System.Web.Mvc;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;

namespace ClotheManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        DashboardRepository repo = new DashboardRepository();

        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();

            model.TotalProducts = repo.TotalProducts();

            model.TotalCategories = repo.TotalOrders();

            model.LowStockProducts = repo.LowStockProducts();

            model.TotalRevenue = 0;

            return View(model);
        }
    }
}