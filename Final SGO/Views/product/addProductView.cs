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

namespace Final_SGO.Views.product
{
    public partial class addProductView : Form
    {
        private productController productController = new productController();
        public addProductView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                productController.AddProduct(txtName.Text, decimal.Parse(txtPrice.Text), txtProvider.Text, txtMaterial.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }
        }
    }
}
