using System.Web.Mvc;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using System.Linq;
namespace ClotheManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repo = new ProductRepository();

        public ActionResult Index(string search)
        {
            var products = repo.GetAll();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                products = products.Where(x =>
                    x.ProductName.ToLower().Contains(search) ||
                    x.Category.ToLower().Contains(search)
                ).ToList();
            }

            return View(products);
        }
        

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = repo.GetById(id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Product product = new Product();
            product.IsActive = true;
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            product.IsActive = true;

            if (!ModelState.IsValid)
                return View(product);

            if (repo.Insert(product))
            {
                TempData["Success"] = "Product Added Successfully";
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            product.IsActive = true;

            if (!ModelState.IsValid)
                return View(product);

            repo.Update(product);

            TempData["Success"] = "Product Updated Successfully";

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (repo.Delete(id))
            {
                TempData["Success"] = "Product Deleted Successfully";
            }

            return RedirectToAction("Index");
        }
    }
}