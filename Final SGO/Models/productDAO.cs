using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Entitys.productsEntity;

namespace Final_SGO.Models
{
    public class productDAO
    {
        public void productListConnection(List<Product> products,string query)
        {
            using (SqlConnection connection = dataAccessObject.GetConnection())
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
        }
        public void productAdd(string Name, decimal Price, string Provider, string Material, string query)
        {
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
