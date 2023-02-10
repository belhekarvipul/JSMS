using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeColors();
            lblApplicationName.Text = Common.ApplicationName;
            Text = Common.ApplicationShortName + ": Login";
            txtLoginId.Focus();
            lblError.Text = string.Empty;
            Common.LoggedInUserId = 0;
            Common.LoggedInUserName = string.Empty;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            txtLoginId.Text = string.Empty;
            txtPassword.Text = string.Empty;
            radioSales.Checked = true;
            txtLoginId.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginId = txtLoginId.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrWhiteSpace(loginId) && !string.IsNullOrWhiteSpace(password))
            {
                string role = Common.Roles.Admin.ToString();

                if (radioSales.Checked)
                    role = Common.Roles.Salesman.ToString();

                DataSet dsUser = new DAL().Login(loginId, Utils.Encrypt(password), role);
                if (dsUser != null && dsUser.Tables.Count > 0 && dsUser.Tables[0].Rows.Count > 0)
                {
                    Common.LoggedInUserId = Convert.ToInt32(dsUser.Tables[0].Rows[0]["UserId"]);
                    Common.LoggedInUserName = dsUser.Tables[0].Rows[0]["Name"].ToString();
                    Hide();
                    if (role == Common.Roles.Admin.ToString())
                        new Dashboard().Show();
                    else
                        new Sales().Show();
                }
                else
                {
                    lblError.Text = "Incorrect credentials.";
                }
            }
            else
            {
                lblError.Text = "Enter credentials.";
            }
        }

        private void InitializeColors()
        {
            panelSideBarMain.BackColor = Common.MainColorDark;
            lblApplicationName.BackColor = linkLabel1.LinkColor = lblError.ForeColor = Common.MainColor;
            panelSideBar.BackColor = panelFooter.BackColor = Common.BackgroundColorDark;
            BackColor = txtPassword.BackColor = txtLoginId.BackColor = Common.BackgroundColor;
            btnLogin.ForeColor = btnReset.ForeColor = Common.ButtonTextColor;
            lblApplicationName.ForeColor = lblLoginId.ForeColor = lblPassword.ForeColor = radioSales.ForeColor = radioAdmin.ForeColor = lblDevelopedBy.ForeColor = txtPassword.ForeColor = txtLoginId.ForeColor = Common.LabelColor;
        }
    }
}
