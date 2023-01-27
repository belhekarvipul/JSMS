using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            dateTimer.Start();
            Reset();
            LoadCategories();
        }

        #region Private Methods
        private void LoadCategories()
        {
            DataSet ds = new DAL().GetCategories();
            dataGridCategories.DataSource = ds.Tables[0];
        }
        private void Reset()
        {
            lblCategoryId.Text = "0";
            txtCategory.Text = String.Empty;
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Dashboard().Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }
    }
}
