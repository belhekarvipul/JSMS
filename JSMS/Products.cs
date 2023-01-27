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
            timerDateTime.Start();
            LoadProducts();
            LoadCategories();
            LoadMetal();
        }
        
        #region Events
        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var x = ddlCategories.Text;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Hide();
            new Dashboard().Show();
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
            ddlCategories.Items.Clear();
            DataSet ds = new DAL().GetCategories();
            ddlCategories.DataSource = ds.Tables[0];
            ddlCategories.DisplayMember = "Name";
            ddlCategories.ValueMember = "CategoryId";
            ddlCategories.SelectedIndex = 0;
        }
        private void LoadMetal()
        {
            ddlMetal.Items.Clear();
            ddlMetal.Items.Add("Gold");
            ddlMetal.Items.Add("Silver");
            ddlMetal.Items.Add("Platinum");
            ddlMetal.SelectedIndex = 0;
        }
        #endregion

        private void timerDateTime_Tick(object sender, System.EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }
    }
}
