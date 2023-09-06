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
    public partial class logInView : Form
    {
        private logInController logInController = new logInController();
        public logInView()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool logInResult = logInController.LogIn(txtUser.Text, txtPassword.Text);
            if (logInResult == true )
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión. Por favor intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
