using System.Collections.Generic;

namespace ClotheManagementSystem.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }

        public int TotalCategories { get; set; }

        public int LowStockProducts { get; set; }

        public decimal TotalRevenue { get; set; }

        public List<Product> Products { get; set; }

        public List<Product> RecentProducts { get; set; }

        public List<Order> RecentOrders { get; set; }
    }

    public class ProductSummary
    {
        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }

        public string Status { get; set; }
    }
}