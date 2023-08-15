using Final_SGO.Models;
using Final_SGO.Views.product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_SGO.Entitys.productsEntity;
using static Final_SGO.Models.productDAO;

namespace Final_SGO.Controller
{
    public class productController
    {
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            productDAO productDAO = new productDAO();

            string query = "select Product_Id,Product_Name,Product_Price,Product_Provider,Product_Material from Products";

            productDAO.productListConnection(products, query);
            
            return products;
        }
        public void AddProduct(string Name, decimal Price, string Provider, string Material)
        {
            productDAO productDAO = new productDAO();

            string query = "insert into Products(Product_Name,Product_Price,Product_Provider,Product_Material) values" + "(@name, @price, @provider, @material)";

            productDAO.productAdd(Name, Price, Provider, Material, query);
        }
        public void ShowProductList(DataGridView dataGridView)
        {
            productController productController = new productController();
            dataGridView.DataSource = productController.GetProductList();
        }
    }
}
