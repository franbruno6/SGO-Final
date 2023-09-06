using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Entitys.userEntity;

namespace Final_SGO.Models
{
    public class userDAO
    {
        public User userGet(string query, string username)
        {
            using(SqlConnection connection = dataAccessObject.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    User oUser = new User();
                    if (reader.Read())
                    {
                        oUser.Id = reader.GetInt32(0);
                        oUser.UserName = reader.GetString(1);
                        oUser.Password = reader.GetString(2);
                        reader.Close();
                    }
                    dataAccessObject.CloseConnection();
                    return oUser;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la db " + ex.Message);

                }
            }
        }
    }
}
