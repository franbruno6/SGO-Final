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

namespace Final_SGO.Views
{
    public partial class mainView : Form
    {
        public mainView()
        {
            InitializeComponent();
        }

        private static productView productChild;
        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (productChild == null || productChild.IsDisposed)
            {
                productChild = new productView();
                productChild.MdiParent = this;
                productChild.Show();
                productChild.FormBorderStyle = FormBorderStyle.None;
                productChild.Dock = DockStyle.Fill;
            }
            else
            {
                if (productChild.WindowState == FormWindowState.Minimized){
                    productChild.WindowState = FormWindowState.Normal;
                    productChild.BringToFront();
                }
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
