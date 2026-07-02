using ClotheManagementSystem.DAL;
using ClotheManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClotheManagementSystem.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBHelper db = new DBHelper();

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_GetProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        Category = dr["Category"].ToString(),
                        Price = Convert.ToDecimal(dr["Price"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        Description = dr["Description"].ToString(),
                        ImageUrl = dr["ImageUrl"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"])
                    });
                }
            }

            return products;
        }

        public Product GetById(int id)
        {
            Product product = null;

            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_GetProductById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", id);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    product = new Product
                    {
                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        Category = dr["Category"].ToString(),
                        Price = Convert.ToDecimal(dr["Price"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        Description = dr["Description"].ToString(),
                        ImageUrl = dr["ImageUrl"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"])
                    };
                }
            }

            return product;
        }

        public bool Insert(Product product)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_AddProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Description", product.Description ?? "");
                cmd.Parameters.AddWithValue("@ImageUrl", product.ImageUrl ?? "");

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(Product product)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_UpdateProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Description", product.Description ?? "");
                cmd.Parameters.AddWithValue("@ImageUrl", product.ImageUrl ?? "");

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection con = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("USP_DeleteProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", id);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}