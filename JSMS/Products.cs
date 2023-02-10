using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Products";
            LoadProducts();
            LoadCategories();
            LoadMetal();
            Reset();
        }

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                int result = new DAL().SaveProduct(int.Parse(lblProductId.Text), txtProductName.Text, txtProductDescription.Text, txtPrice.Text, txtStock.Text, Convert.ToInt32(ddlCategories.SelectedValue), ddlMetal.Text);
                if (result > 0)
                {
                    Reset();
                    lblResult.Text = "Product saved successfully.";
                    LoadProducts();
                }
                else
                    lblResult.Text = "Failed to save product.";
            }
            else
            {
                lblResult.Text = "Fields with * are mandatory.";
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (Common.GetDeleteConfirmation())
            {
                var selectedRows = dataGridProducts.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    lblResult.Text = string.Empty;
                    int result = new DAL().DeleteProduct(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

                    if (result > 0)
                    {
                        Reset();
                        lblResult.Text = "Product deleted successfully.";
                        LoadProducts();
                    }
                    else
                        lblResult.Text = "Failed to delete product.";
                }
                else
                    lblResult.Text = "Please select a record.";
            }
        }

        private void dataGridProducts_DoubleClick(object sender, EventArgs e)
        {
            var selectedRows = dataGridProducts.SelectedRows;
            if (selectedRows.Count > 0)
            {
                lblResult.Text = string.Empty;
                lblProductId.Text = selectedRows[0].Cells[0].Value.ToString();
                txtProductName.Text = selectedRows[0].Cells["Name"].Value.ToString();
                txtProductDescription.Text = selectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = selectedRows[0].Cells["Price"].Value.ToString();
                txtStock.Text = selectedRows[0].Cells["Stock"].Value.ToString();
                ddlMetal.SelectedIndex = ddlMetal.FindString(selectedRows[0].Cells["Metal"].Value.ToString());
                ddlCategories.SelectedIndex = ddlCategories.FindString(selectedRows[0].Cells["Category"].Value.ToString());
            }
        }

        private void dataGridProducts_Sorted(object sender, EventArgs e)
        {
            Reset();
        }

        private void timerDateTime_Tick(object sender, System.EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Hide();
            new Dashboard().Show();
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region PrivateMethods
        private void LoadProducts()
        {
            DataSet ds = new DAL().GetProducts();
            dataGridProducts.DataSource = ds.Tables[0];
        }
        private void LoadCategories()
        {
            Common.LoadCategories(ddlCategories);
        }
        private void LoadMetal()
        {
            Common.LoadMetal(ddlMetal);
        }
        private void Reset()
        {
            lblProductId.Text = "0";
            txtProductName.Text = string.Empty;
            txtProductName.Focus();
            txtProductDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            lblResult.Text = string.Empty;
            ddlMetal.SelectedIndex = 0;
            ddlCategories.SelectedIndex = 0;
        }

        private void InitializeColors()
        {
            panelSideBarMain.BackColor = Common.MainColorDark;
            lblFormName.BackColor = btnBack.BackColor = Common.MainColor;
            btnNew.ForeColor = btnSave.ForeColor = btnDelete.ForeColor = Common.ButtonTextColor;
            panelTop.BackColor = panelSideBar.BackColor = panelFooter.BackColor = Common.BackgroundColorDark;
            lblFormName.ForeColor = btnBack.ForeColor = lblResult.ForeColor = lblTime.ForeColor =
                label1.ForeColor = lblProductId.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor
                 = txtProductName.ForeColor = txtProductDescription.ForeColor = ddlCategories.ForeColor = ddlMetal.ForeColor = txtPrice.ForeColor = txtStock.ForeColor
                = Common.LabelColor;

            BackColor = txtProductName.BackColor = txtProductDescription.BackColor = ddlCategories.BackColor = ddlMetal.BackColor = txtPrice.BackColor = txtStock.BackColor = dataGridProducts.BackgroundColor = panel7.BackColor = Common.BackgroundColor;
        }
        #endregion
    }
}
