using Final_SGO.Controller;
using Final_SGO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_SGO.Views
{
    public partial class productView : Form
    {
        public productView()
        {
            InitializeComponent();
            productController oProductList= new productController();
            dataGridView1.DataSource = oProductList.GetProductList();
        }
    }
}
