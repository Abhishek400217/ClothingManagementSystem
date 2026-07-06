using ClotheManagementSystem.Filters;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using System.Linq;
using System.Web.Mvc;

namespace ClotheManagementSystem.Controllers
{
    [AdminAuthorize]

    public class OrderController : Controller
    {
        OrderRepository repo = new OrderRepository();

        // Order List
        public ActionResult Index(string search)
        {
            var orders = repo.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                orders = orders.Where(x =>
                    x.CustomerName.ToLower().Contains(search) ||
                    x.ProductName.ToLower().Contains(search)
                ).ToList();
            }

            return View(orders);
        }

        // GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Create(Order order)
        {
            order.TotalAmount = order.Price * order.Quantity;

            if (string.IsNullOrEmpty(order.Status))
            {
                order.Status = "Pending";
            }

            repo.Insert(order);

            TempData["Success"] = "Order Added Successfully";
            return RedirectToAction("Index");
        }

        // GET
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Order order = repo.GetById(id);

            return View(order);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            order.TotalAmount = order.Price * order.Quantity;

            repo.Update(order);

            TempData["Success"] = "Order Updated Successfully";
            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            TempData["Success"] = "Order Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}