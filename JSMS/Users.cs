using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Users";
            LoadRoles();
            Reset();
            LoadUsers();
        }

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLoginId.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                int result = new DAL().SaveUser(int.Parse(lblUserId.Text), txtName.Text, txtLoginId.Text, Utils.Encrypt(txtPassword.Text), ddlRole.Text);
                if (result > 0)
                {
                    Reset();
                    lblResult.Text = "User saved successfully.";
                    LoadUsers();
                }
                else
                    lblResult.Text = "Failed to save user.";
            }
            else
            {
                lblResult.Text = "Enter user details.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Common.GetDeleteConfirmation())
            {
                var selectedRows = dataGridUsers.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    lblResult.Text = string.Empty;
                    int result = new DAL().DeleteUser(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "User deleted successfully.";
                        LoadUsers();
                    }
                    else
                        lblResult.Text = "Failed to delete user.";
                }
                else
                    lblResult.Text = "Please select a record.";
            }
        }

        private void dataGridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = dataGridUsers.SelectedRows;
            if (selectedRows.Count > 0)
            {
                lblResult.Text = string.Empty;
                chkShowPassword.Checked = false;
                lblUserId.Text = selectedRows[0].Cells[0].Value.ToString();
                txtName.Text = selectedRows[0].Cells["Name"].Value.ToString();
                txtLoginId.Text = selectedRows[0].Cells["Login Id"].Value.ToString();
                txtPassword.Text = Utils.Decrypt(selectedRows[0].Cells["Password"].Value.ToString());
                ddlRole.SelectedIndex = ddlRole.FindString(selectedRows[0].Cells["Role"].Value.ToString());
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = char.MinValue;
            else
                txtPassword.PasswordChar = '*';
        }

        private void dataGridUsers_Sorted(object sender, EventArgs e)
        {
            Reset();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            Hide();
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Private Methods
        private void LoadUsers()
        {
            DataSet ds = new DAL().GetUsers();
            dataGridUsers.DataSource = ds.Tables[0];
            dataGridUsers.Columns["Password"].Visible = false;
        }

        private void Reset()
        {
            lblUserId.Text = "0";
            txtName.Text = String.Empty;
            txtName.Focus();
            txtLoginId.Text = String.Empty;
            txtPassword.Text = String.Empty;
            ddlRole.SelectedIndex = 0;
            lblResult.Text = string.Empty;
            chkShowPassword.Checked = false;
        }

        private void LoadRoles()
        {
            ddlRole.Items.Clear();
            ddlRole.Items.Add(Common.SelectText);
            foreach (var role in Enum.GetNames(typeof(Common.Roles)))
            {
                ddlRole.Items.Add(role);
            }
            ddlRole.SelectedIndex = 0;
        }

        private void InitializeColors()
        {
            panelSideBarMain.BackColor = Common.MainColorDark;
            lblFormName.BackColor = btnBack.BackColor = Common.MainColor;
            btnNew.ForeColor = btnSave.ForeColor = btnDelete.ForeColor = Common.ButtonTextColor;
            panelTop.BackColor = panelSideBar.BackColor = panelFooter.BackColor = Common.BackgroundColorDark;
            lblFormName.ForeColor = btnBack.ForeColor = lblResult.ForeColor = lblTime.ForeColor =
                lblFormName.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = lblUserId.ForeColor
                 = txtLoginId.ForeColor = txtName.ForeColor = txtPassword.ForeColor = ddlRole.ForeColor = chkShowPassword.ForeColor
                = Common.LabelColor;

            BackColor = txtName.BackColor = txtLoginId.BackColor = txtPassword.BackColor = ddlRole.BackColor = dataGridUsers.BackgroundColor = Common.BackgroundColor;
        }
        #endregion
    }
}
