using System.Collections.Generic;

namespace ClotheManagementSystem.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }

        public int TotalCategories { get; set; }

        public int LowStockProducts { get; set; }

        public decimal TotalRevenue { get; set; }

        public List<ProductSummary> RecentProducts { get; set; }

        public DashboardViewModel()
        {
            RecentProducts = new List<ProductSummary>();
        }
    }

    public class ProductSummary
    {
        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }

        public string Status { get; set; }
    }
}