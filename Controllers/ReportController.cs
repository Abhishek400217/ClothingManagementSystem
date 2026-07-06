using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using System.Linq;
using System.Web.Mvc;

namespace ClotheManagementSystem.Controllers
{
    public class ReportController : Controller
    {
        ProductRepository productRepo = new ProductRepository();
        OrderRepository orderRepo = new OrderRepository();

        public ActionResult Index()
        {
            var products = productRepo.GetAll();
            var orders = orderRepo.GetAll();

            ReportViewModel model = new ReportViewModel();

            model.Products = products;
            model.Orders = orders;

            model.TotalProducts = products.Count;
            model.TotalOrders = orders.Count;

            model.TotalRevenue = orders.Sum(x => x.TotalAmount);

            model.LowStock = products.Count(x => x.Stock <= 5);

            return View(model);
        }
    }
}