using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class KittyInstallment : Form
    {
        DataTable dtCustomers;

        public KittyInstallment()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Kitty Installment";
            Reset();
            LoadInstallments();
        }

        #region Private Methods
        private void LoadInstallments()
        {
            DataSet ds = new DAL().GetCustomers();
            dataGridKittyInstallment.DataSource = ds.Tables[0];
            //dataGridCustomers.Columns["Password"].Visible = false;
        }

        private void Reset()
        {
            lblInstallmentId.Text = "0";
            lblResult.Text = string.Empty;
            txtCustomer.Focus();
            txtGoldRate.Text = "0";
            txtAmount.Text = "0";
            txtInstallmentDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblGoldBooked.Text = "0.00 gms";
            BindCustomers();
        }

        private void InitializeColors()
        {
            pTobBar.BackColor = pFormSideBar.BackColor = pFooter.BackColor = Common.BackgroundColorDark;
            pTitleSideBar.BackColor = Common.MainColorDark;
            pTitleName.BackColor = pTitleBackButton.BackColor = Common.MainColor;
            btnNew.ForeColor = btnSave.ForeColor = btnDelete.ForeColor = Common.ButtonTextColor;
            lblFormName.ForeColor = btnBack.ForeColor = lblResult.ForeColor = lblTime.ForeColor =
                label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor =
                txtCustomer.BackColor = txtGoldRate.BackColor = txtAmount.BackColor = txtInstallmentDate.BackColor = 
                Common.LabelColor;
            tableLayoutPanel1.BackColor = dataGridKittyInstallment.BackgroundColor =
                txtCustomer.BackColor = txtGoldRate.BackColor = txtAmount.BackColor = txtInstallmentDate.BackColor = 
                Common.BackgroundColor;
        }

        private void BindCustomers()
        {
            dtCustomers = new DAL().GetCustomers().Tables[0];
            dtCustomers.CaseSensitive = false;
            dtCustomers.Rows.InsertAt(dtCustomers.NewRow(), 0);
            dtCustomers.Columns.Add("CustomerContact");

            foreach (DataRow row in dtCustomers.Rows)
            {
                row["CustomerContact"] = row["CustomerName"] + " - " + row["ContactNumber"];
            }

            txtCustomer.DisplayMember = "CustomerContact";
            txtCustomer.ValueMember = "CustomerId";
            txtCustomer.DataSource = dtCustomers;
            txtCustomer.KeyUp += txtCustomerName_KeyUp;
        }

        private void txtCustomerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.ShiftKey))
            {
                ComboBox customerComboBox = (ComboBox)sender;
                string searchText = customerComboBox.Text;

                DataRow[] filteredRows = dtCustomers.Select("CustomerContact Like '%" + searchText + "%'");
                DataTable filteredDt = filteredRows.Length > 0 ? filteredRows.CopyToDataTable() : dtCustomers;

                customerComboBox.DataSource = filteredDt;
                customerComboBox.DroppedDown = true;
                customerComboBox.Text = searchText;
                customerComboBox.SelectionStart = searchText.Length;
            }
        }

        private void CalculateGoldBooking()
        {
            double goldBooked = 0.00;
            int amount = Convert.ToInt32(string.IsNullOrWhiteSpace(txtAmount.Text) ? "0" : txtAmount.Text);
            double rate = Convert.ToDouble(string.IsNullOrWhiteSpace(txtGoldRate.Text) ? "0" : txtGoldRate.Text);
            if (amount > 0 && rate > 0)
                goldBooked = amount / rate;
            lblGoldBooked.Text = String.Format("{0:0.00}", goldBooked) + " gms";
        }
        #endregion

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtContactNumber.Text))
            //{
            //    int result = new DAL().SaveCustomer(int.Parse(lblCustomerId.Text), txtCustomerName.Text, txtContactNumber.Text, txtAddress.Text, txtPan.Text);
            //    if (result > 0)
            //    {
            //        Reset();
            //        lblResult.Text = "Customer saved successfully.";
            //        LoadCustomers();
            //    }
            //    else
            //        lblResult.Text = "Failed to save Customer.";
            //}
            //else
            //{
            //    lblResult.Text = "Enter customer details.";
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Common.GetDeleteConfirmation())
            {
                var selectedRows = dataGridKittyInstallment.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    lblResult.Text = string.Empty;
                    int result = new DAL().DeleteCustomer(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "Customer deleted successfully.";
                        LoadInstallments();
                    }
                    else
                        lblResult.Text = "Failed to delete customer.";
                }
                else
                    lblResult.Text = "Please select a record.";
            }
        }

        private void dataGridKittyInstallment_Sorted(object sender, EventArgs e)
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

        private void KittyInstallment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtGoldRate_TextChanged(object sender, EventArgs e)
        {
            CalculateGoldBooking();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateGoldBooking();
        }
        #endregion        
    }
}
