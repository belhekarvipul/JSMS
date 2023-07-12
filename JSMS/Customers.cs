using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;
namespace JSMS
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Customers";
            Reset();
            LoadCustomers();
        }

        #region Private Methods
        private void LoadCustomers()
        {
            DataSet ds = new DAL().GetCustomers();
            dataGridCustomers.DataSource = ds.Tables[0];
            //dataGridCustomers.Columns["Password"].Visible = false;
        }

        private void Reset()
        {
            lblCustomerId.Text = "0";
            txtCustomerName.Text = String.Empty;
            txtCustomerName.Focus();
            txtContactNumber.Text = String.Empty;
            txtPan.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }        

        private void InitializeColors()
        {
            pTobBar.BackColor = pFormSideBar.BackColor = pFooter.BackColor = Common.BackgroundColorDark;
            pTitleSideBar.BackColor = Common.MainColorDark;
            pTitleName.BackColor = pTitleBackButton.BackColor = Common.MainColor;
            btnNew.ForeColor = btnSave.ForeColor = btnDelete.ForeColor = Common.ButtonTextColor;
            lblFormName.ForeColor = btnBack.ForeColor = lblResult.ForeColor = lblTime.ForeColor =
                label2.ForeColor = label3.ForeColor = lblCustomerId.ForeColor = label3.ForeColor = label1.ForeColor =
                txtCustomerName.ForeColor = txtContactNumber.ForeColor = txtPan.ForeColor = txtAddress.ForeColor =
                Common.LabelColor;
            tableLayoutPanel1.BackColor = dataGridCustomers.BackgroundColor =
                txtCustomerName.BackColor = txtContactNumber.BackColor = txtPan.BackColor = txtAddress.BackColor =
                Common.BackgroundColor;
        }
        #endregion

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtContactNumber.Text))
            {
                int result = new DAL().SaveCustomer(int.Parse(lblCustomerId.Text), txtCustomerName.Text, txtContactNumber.Text, txtAddress.Text, txtPan.Text);
                if (result > 0)
                {
                    Reset();
                    lblResult.Text = "Customer saved successfully.";
                    LoadCustomers();
                }
                else
                    lblResult.Text = "Failed to save Customer.";
            }
            else
            {
                lblResult.Text = "Enter customer details.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Common.GetDeleteConfirmation())
            {
                var selectedRows = dataGridCustomers.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    lblResult.Text = string.Empty;
                    int result = new DAL().DeleteCustomer(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "Customer deleted successfully.";
                        LoadCustomers();
                    }
                    else
                        lblResult.Text = "Failed to delete customer.";
                }
                else
                    lblResult.Text = "Please select a record.";
            }
        }

        private void dataGridCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = dataGridCustomers.SelectedRows;
            if (selectedRows.Count > 0)
            {
                lblResult.Text = string.Empty;
                lblCustomerId.Text = selectedRows[0].Cells[0].Value.ToString();
                txtCustomerName.Text = selectedRows[0].Cells["CustomerName"].Value.ToString();
                txtContactNumber.Text = selectedRows[0].Cells["ContactNumber"].Value.ToString();
                txtPan.Text = selectedRows[0].Cells["PanNumber"].Value.ToString();
                txtAddress.Text = selectedRows[0].Cells["Address"].Value.ToString();
            }
        }

        private void dataGridCustomers_Sorted(object sender, EventArgs e)
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

        private void Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
