using Final_SGO.Models;
using Final_SGO.Views.product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Models.productsModel;

namespace Final_SGO.Controller
{
    public class productController
    {
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            string query = "select Product_Id,Product_Name,Product_Price,Product_Provider,Product_Material from Products";

            using(SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Product oProduct = new Product();
                        oProduct.Id = reader.GetInt32(0);
                        oProduct.Name = reader.GetString(1);
                        oProduct.Price = reader.GetDecimal(2);
                        oProduct.Provider = reader.GetString(3);
                        oProduct.Material = reader.GetString(4);
                        products.Add(oProduct);
                    }
                    reader.Close();
                    dataAccessObject.CloseConnection();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la db " + ex.Message);
                }
            }
            return products;
        }
        public void AddProduct(string Name, decimal Price, string Provider, string Material)
        {
            string query = "insert into Products(Product_Name,Product_Price,Product_Provider,Product_Material) values" + "(@name, @price, @provider, @material)";
            using (SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@price", Price);
                command.Parameters.AddWithValue("@provider", Provider);
                command.Parameters.AddWithValue("@material", Material);
                try
                {
                    command.ExecuteNonQuery();
                    dataAccessObject.CloseConnection();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la db " + ex.Message);
                }
            }
        }
    }
}
