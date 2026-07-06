using System.Collections.Generic;

namespace ClotheManagementSystem.Models
{
    public class ReportViewModel
    {
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalRevenue { get; set; }

        public int LowStockProducts { get; set; }

        public List<Order> RecentOrders { get; set; }

        public List<Product> LowStockList { get; set; }
    }
}