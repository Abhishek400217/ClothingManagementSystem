using System.Web.Mvc;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;

namespace ClotheManagementSystem.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository repo = new OrderRepository();

        // Order List
        public ActionResult Index()
        {
            var orders = repo.GetAll();
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

            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            repo.Delete(id);

            return RedirectToAction("Index");
        }
    }
}