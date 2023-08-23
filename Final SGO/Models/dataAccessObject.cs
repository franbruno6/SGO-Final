using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_SGO.Models
{
    internal class dataAccessObject
    {
        //Connection String PC
        private static readonly string connectionString = "Data Source=DESKTOP-1C3TO16;Initial Catalog = Sistema_gestion_obra; Integrated Security = True";
        //Connection String Notebook
        //private static readonly string connectionString = "Data Source=DESKTOP-IMHLUUF;Initial Catalog=Sistema_gestion_obra;Integrated Security=True";
        private static SqlConnection connection;
        public static SqlConnection GetConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la db " + ex.Message);
            }
        }
        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}

