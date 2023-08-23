using Final_SGO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_SGO.Entitys.productsEntity;

namespace Final_SGO.Views.product
{
    public partial class editProductView : Form
    {
        private productController productController = new productController();
        public editProductView(Product product)
        {
            InitializeComponent();
            productController.ShowValues(product, txtId, txtName, txtPrice, txtProvider, txtMaterial);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            productController.EditProduct(int.Parse(txtId.Text), txtName.Text, decimal.Parse(txtPrice.Text), txtProvider.Text, txtMaterial.Text);
            this.Close();
        }
    }
}
