using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class KittyRegistration : Form
    {
        DataTable dtCustomers;

        public KittyRegistration()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Kitty Registration";
            Reset();
            LoadRegistrations();
        }

        #region Private Methods
        private void Reset()
        {
            lblResult.Text = string.Empty;
            lblRegistrationId.Text = "0";
            txtCustomerName.Focus();
            txtAmount.Text = "0";
            txtGoldRate.Text = "0";
            txtStartDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            txtEndDate.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");
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
                label2.ForeColor = label3.ForeColor = lblTime.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = label7.ForeColor =
                txtCustomerName.ForeColor = txtAmount.ForeColor = txtStartDate.ForeColor = txtEndDate.ForeColor = txtGoldRate.ForeColor =
                Common.LabelColor;
            tableLayoutPanel1.BackColor = dataGridKittyRegistrations.BackgroundColor = 
                txtCustomerName.BackColor = txtAmount.BackColor = txtStartDate.BackColor = txtEndDate.BackColor = txtGoldRate.BackColor = 
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

            txtCustomerName.DisplayMember = "CustomerContact";
            txtCustomerName.ValueMember = "CustomerId";
            txtCustomerName.DataSource = dtCustomers;
            txtCustomerName.KeyUp += txtCustomerName_KeyUp;
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

        private void LoadRegistrations()
        {
            DataSet ds = new DAL().GetKittyRegistration();
            dataGridKittyRegistrations.DataSource = ds.Tables[0];
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
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateGoldBooking();
        }

        private void txtGoldRate_TextChanged(object sender, EventArgs e)
        {
            CalculateGoldBooking();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtCustomerName.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtAmount.Text) || txtAmount.Text == "0" || string.IsNullOrWhiteSpace(txtGoldRate.Text) || txtGoldRate.Text == "0"))
            {
                if (txtCustomerName.SelectedIndex > 0)
                {
                    int result = new DAL().SaveKittyRegistration(Convert.ToInt32(txtCustomerName.SelectedValue), txtAmount.Text, txtStartDate.Text, txtEndDate.Text,
                        lblGoldBooked.Text.Split(' ')[0].Trim());
                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "Registration saved successfully.";
                        LoadRegistrations();
                    }
                    else
                        lblResult.Text = "Failed to save Registration.";
                }
                else
                    lblResult.Text = "Select customer properly.";
            }
            else
            {
                lblResult.Text = "Enter registration details.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Common.GetDeleteConfirmation())
            {
                var selectedRows = dataGridKittyRegistrations.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    lblResult.Text = string.Empty;
                    int result = new DAL().DeleteKittyRegistrations(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "Registration deleted successfully.";
                        LoadRegistrations();
                    }
                    else
                        lblResult.Text = "Failed to delete registration.";
                }
                else
                    lblResult.Text = "Please select a record.";
            }
        }

        private void dataGridKittyRegistrations_Sorted(object sender, EventArgs e)
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

        private void KittyRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
