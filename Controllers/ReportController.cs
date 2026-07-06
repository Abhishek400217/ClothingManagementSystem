using ClotheManagementSystem.Filters;
using ClotheManagementSystem.Models;
using ClotheManagementSystem.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Linq;
using System.Web.Mvc;
namespace ClotheManagementSystem.Controllers
{
    [AdminAuthorize]

    public class ReportController : Controller
    {

        ProductRepository productRepo = new ProductRepository();
        OrderRepository orderRepo = new OrderRepository();

        public ActionResult Index()
        {
            ProductRepository productRepo = new ProductRepository();
            OrderRepository orderRepo = new OrderRepository();

            var products = productRepo.GetAll();
            var orders = orderRepo.GetAll();

            ReportViewModel model = new ReportViewModel();

            model.TotalProducts = products.Count;
            model.TotalOrders = orders.Count;
            model.TotalRevenue = orders.Sum(x => x.TotalAmount);
            model.LowStockProducts = products.Count(x => x.Stock <= 5);

            model.RecentOrders = orders
                .OrderByDescending(x => x.OrderId)
                .Take(5)
                .ToList();

            model.LowStockList = products
                .Where(x => x.Stock <= 5)
                .ToList();

            return View(model);
        }

        public FileResult DownloadPdf()
        {
            MemoryStream ms = new MemoryStream();

            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);

            PdfWriter.GetInstance(doc, ms);

            doc.Open();

            Paragraph title = new Paragraph("BUSINESS REPORT");
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;

            doc.Add(title);

            ProductRepository productRepo = new ProductRepository();
            OrderRepository orderRepo = new OrderRepository();

            var products = productRepo.GetAll();
            var orders = orderRepo.GetAll();

            doc.Add(new Paragraph("Total Products : " + products.Count));
            doc.Add(new Paragraph("Total Orders : " + orders.Count));
            doc.Add(new Paragraph("Low Stock : " + products.Count(x => x.Stock <= 5)));
            doc.Add(new Paragraph("Total Revenue : Rs. " + orders.Sum(x => x.TotalAmount)));

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Generated On : " + System.DateTime.Now));

            doc.Close();

            return File(ms.ToArray(),
                "application/pdf",
                "BusinessReport.pdf");
        }
    }
}