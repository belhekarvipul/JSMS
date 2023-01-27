using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblApplicationName.Text = Common.ApplicationName;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLoginId.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            new Dashboard().Show();
        }
    }
}
