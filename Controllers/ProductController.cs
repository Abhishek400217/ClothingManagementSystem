using System.Web.Mvc;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using System.Linq;
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

            if (repo.Insert(product))
            {
                return RedirectToAction("Index");
            }

            return View(product);
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
            product.IsActive = true;

            if (repo.Update(product))
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}