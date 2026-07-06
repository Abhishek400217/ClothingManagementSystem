using System.Collections.Generic;

namespace ClotheManagementSystem.Models
{
    public class ReportViewModel
    {
        public int TotalProducts { get; set; }

        public int TotalOrders { get; set; }

        public decimal TotalRevenue { get; set; }

        public int LowStock { get; set; }

        public List<Product> Products { get; set; }

        public List<Order> Orders { get; set; }

    }
}