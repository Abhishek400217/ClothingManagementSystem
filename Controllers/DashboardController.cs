using ClotheManagementSystem.Filters;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using System.Linq;
using System.Web.Mvc;

namespace ClotheManagementSystem.Controllers
{
    [AdminAuthorize]

    public class DashboardController : Controller
    {
        ProductRepository productRepo = new ProductRepository();
        OrderRepository orderRepo = new OrderRepository();


        public ActionResult Index()
        {
            var products = productRepo.GetAll();
            var orders = orderRepo.GetAll();

            DashboardViewModel model = new DashboardViewModel();

            model.TotalProducts = products.Count;
            model.TotalCategories = products.Select(x => x.Category).Distinct().Count();
            model.LowStockProducts = products.Count(x => x.Stock <= 5);
            model.TotalRevenue = orders.Sum(x => x.TotalAmount);

            model.RecentOrders = orders
                .OrderByDescending(x => x.OrderId)
                .Take(5)
                .ToList();
            model.Products = products;

            model.RecentProducts = products
                .OrderByDescending(x => x.ProductId)
                .Take(5)
                .ToList();
            return View(model);

        }
    }
}