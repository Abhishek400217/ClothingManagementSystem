using System.Web.Mvc;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;

namespace ClotheManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repo = new ProductRepository();

        public ActionResult Index()
        {
            var products = repo.GetAll();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            product.IsActive = true;

            repo.Insert(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = repo.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (repo.Update(product))
                {
                    TempData["Success"] = "Product updated successfully!";
                    return RedirectToAction("Index");
                }
            }

            return View(product);
        }

        public ActionResult Delete(int id)
        {
            if (repo.Delete(id))
            {
                TempData["Success"] = "Product deleted successfully!";
            }

            return RedirectToAction("Index");
        }
    }
}