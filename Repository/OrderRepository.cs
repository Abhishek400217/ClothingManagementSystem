using ClotheManagementSystem.DAL;
using ClotheManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClotheManagementSystem.Repository
{
    public class OrderRepository : IOrderRepository
    {
        DBHelper db = new DBHelper();

        public List<Order> GetAll()
        {
            List<Order> list = new List<Order>();

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_GetOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Order
                    {
                        OrderId = Convert.ToInt32(dr["OrderId"]),
                        CustomerName = dr["CustomerName"].ToString(),
                        ProductName = dr["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        Price = Convert.ToDecimal(dr["Price"]),
                        TotalAmount = Convert.ToDecimal(dr["TotalAmount"]),
                        OrderDate = Convert.ToDateTime(dr["OrderDate"]),
                        Status = dr["Status"].ToString()
                    });
                }
            }

            return list;
        }

        public Order GetById(int id)
        {
            Order order = null;

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_GetOrderById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderId", id);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    order = new Order
                    {
                        OrderId = Convert.ToInt32(dr["OrderId"]),
                        CustomerName = dr["CustomerName"].ToString(),
                        ProductName = dr["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        Price = Convert.ToDecimal(dr["Price"]),
                        TotalAmount = Convert.ToDecimal(dr["TotalAmount"]),
                        OrderDate = Convert.ToDateTime(dr["OrderDate"]),
                        Status = dr["Status"].ToString()
                    };
                }
            }

            return order;
        }

        public bool Insert(Order order)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_AddOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerName", order.CustomerName);
                cmd.Parameters.AddWithValue("@ProductName", order.ProductName);
                cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                cmd.Parameters.AddWithValue("@Price", order.Price);
                cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", order.Status);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    SqlCommand stockCmd = new SqlCommand("USP_UpdateStock", con);
                    stockCmd.CommandType = CommandType.StoredProcedure;

                    stockCmd.Parameters.AddWithValue("@ProductName", order.ProductName);
                    stockCmd.Parameters.AddWithValue("@Quantity", order.Quantity);

                    stockCmd.ExecuteNonQuery();

                    return true;
                }

                return false;
            }
        }

        public bool Update(Order order)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_UpdateOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderId", order.OrderId);
                cmd.Parameters.AddWithValue("@CustomerName", order.CustomerName);
                cmd.Parameters.AddWithValue("@ProductName", order.ProductName);
                cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                cmd.Parameters.AddWithValue("@Price", order.Price);
                cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", order.Status);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_DeleteOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderId", id);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}