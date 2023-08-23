using Final_SGO.Controller;
using Final_SGO.Models;
using Final_SGO.Views.product;
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

namespace Final_SGO.Views
{
    public partial class productView : Form
    {
        private productController productController = new productController();
        public productView()
        {
            InitializeComponent();
            this.Activated += productView_Activated;
        }
        private void productView_Activated(object sender, EventArgs e)
        {
            productController.ShowProductList(dataGridProducts);
        }
        private addProductView addProductChild;
        private void btnAddProduct_Click(object sender, EventArgs e)
        { 
            if (addProductChild == null || addProductChild.IsDisposed)
            {
                addProductChild = new addProductView();
                addProductChild.MdiParent = mainView.ActiveForm;
                addProductChild.Show();
                //addProductChild.FormBorderStyle = FormBorderStyle.None;
                addProductChild.Dock = DockStyle.Fill;
            }
            else
            {
                if (addProductChild.WindowState == FormWindowState.Minimized)
                {
                    addProductChild.WindowState = FormWindowState.Normal;
                    addProductChild.BringToFront();
                }
            }
        }

        private editProductView editProductChild;
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = (int)productController.GetProductId(dataGridProducts);
                Product product = productController.GetProduct(productId);
                if (editProductChild == null || editProductChild.IsDisposed)
                {
                    
                    editProductChild = new editProductView(product);
                    editProductChild.MdiParent = mainView.ActiveForm;
                    editProductChild.Show();
                    //editProductChild.FormBorderStyle = FormBorderStyle.None;
                    editProductChild.Dock = DockStyle.Fill;
                }
                else
                {
                    if (editProductChild.WindowState == FormWindowState.Minimized)
                    {
                        editProductChild.WindowState = FormWindowState.Normal;
                        editProductChild.BringToFront();
                    }
                }
                
            }catch (Exception ex)
            {
                throw new Exception("Hay un error y pUNTO " + ex.Message);
            }
        }
    }
}

