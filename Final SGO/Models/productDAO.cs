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
        public void productListGet(string query, List<Product> products)
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
        public void productAdd(string query, string name, decimal price, string provider, string material)
        {
            using (SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@provider", provider);
                command.Parameters.AddWithValue("@material", material);
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
        public Product productGet(string query, int id)
        {
            using (SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    Product oProduct = new Product();
                    if (reader.Read())
                    {
                        oProduct.Id = reader.GetInt32(0);
                        oProduct.Name = reader.GetString(1);
                        oProduct.Price = reader.GetDecimal(2);
                        oProduct.Provider = reader.GetString(3);
                        oProduct.Material = reader.GetString(4);
                        reader.Close();
                    }
                    dataAccessObject.CloseConnection();
                    return oProduct;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la db " + ex.Message);
                }
            }
        }
        public void productUpdate(string query, int id, string name, decimal price, string provider, string material)
        {
            using (SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(@"id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@provider", provider);
                command.Parameters.AddWithValue("@material", material);
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
        public void productDelete(string query, int id)
        {
            using (SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    command.ExecuteNonQuery();
                    dataAccessObject.CloseConnection();
                }
                catch(Exception ex) {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
