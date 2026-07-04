using ClotheManagementSystem.DAL;
using System.Data.SqlClient;

namespace ClotheManagementSystem.Repository
{
    public class DashboardRepository
    {
        DBHelper db = new DBHelper();

        public int TotalProducts()
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products", con);

                con.Open();

                return (int)cmd.ExecuteScalar();
            }
        }

        public int TotalOrders()
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", con);

                con.Open();

                return (int)cmd.ExecuteScalar();
            }
        }

        public int LowStockProducts()
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock<=5", con);

                con.Open();

                return (int)cmd.ExecuteScalar();
            }
        }
    }
}