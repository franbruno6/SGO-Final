using Final_SGO.Models;
using Final_SGO.Views;
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
        private productDAO productDAO = new productDAO();
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();
            string query = "select Product_Id,Product_Name,Product_Price,Product_Provider,Product_Material from Products";
            productDAO.productListConnection(query, products);
            return products;
        }
        public void ShowProductList(DataGridView dataGridView)
        {
            productController productController = new productController();
            dataGridView.DataSource = productController.GetProductList();
        }
        public void AddProduct(string name, decimal price, string provider, string material)
        {
            string query = "insert into Products(Product_Name,Product_Price,Product_Provider,Product_Material) values" + "(@name, @price, @provider, @material)";
            productDAO.productAdd(query, name, price, provider, material);
        }
        public void EditProduct(int id, string name, decimal price, string provider, string material)
        {
            string query = "update Products " + "set Product_Name=@name, Product_Price=@price, Product_Provider=@provider, Product_Material=@material " + "where Product_Id=@id";
            productDAO.productUpdate(query, id, name, price, provider, material);
        }
        public void DeleteProduct(string Name)
        {

        }
        public int? GetProductId(DataGridView dataGridView)
        {
            try
            {
                return int.Parse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }catch(Exception)
            {
                return null;
            }
        }
        public Product GetProduct(int id)
        {
            string query = "select Product_Id, Product_Name, Product_Price, Product_Provider, Product_Material from Products " + "where Product_Id=@id";
            Product product = productDAO.productGet(query, id);
            return product;
        }
        public void ShowValues(Product product, TextBox idTxt, TextBox nameTxt, TextBox priceTxt, TextBox providerTxt, TextBox materialTxt)
        {
            idTxt.Text = product.Id.ToString();
            nameTxt.Text = product.Name.ToString();
            priceTxt.Text = product.Price.ToString();
            providerTxt.Text = product.Provider.ToString();
            materialTxt.Text = product.Material.ToString();
        }
    }
}
