using JSMS.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JSMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            InitializeColors();
            timerDateTime.Start();
            Text = Common.ApplicationShortName + ": Dashboard";
            lblApplicationName.Text = Common.ApplicationName;
            Common.LoadCategories(ddlCategory);
            Common.LoadMetal(ddlMetal);
            LoadStockChart();
            
            if (Common.IsDarkMode)
                chkDarkMode.Checked = true;
            else
                chkDarkMode.Checked = false;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
            Hide();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            new Categories().Show();
            Hide();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void LoadStockChart()
        {
            string metal = ddlMetal.Items.Count > 0 ? (ddlMetal.SelectedIndex == 0 ? "0" : ddlMetal.Text) : "0";
            string categoryId = ddlCategory.Items.Count > 0 ? (ddlCategory.SelectedIndex == 0 ? "0" : ddlCategory.SelectedValue.ToString()) : "0";

            chartDataByMetal.Series["Stock"].ChartType = SeriesChartType.Pie;
            chartDataByMetal.Series["Stock"].Points.Clear();
            chartDataByMetal.Legends[0].Enabled = true;
            chartDataByMetal.ChartAreas[0].Area3DStyle.Enable3D = true;

            var dsChartData = new DAL().GetCurrentStocksData(metal, categoryId);
            if (dsChartData != null && dsChartData.Tables.Count > 0 && dsChartData.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dsChartData.Tables[0].Rows)
                {
                    chartDataByMetal.Series["Stock"].Points.AddXY(row["Name"], row["Stock"]);
                }
            }
        }

        private void InitializeColors()
        {
            panelSideBarMain.BackColor = Common.MainColorDark;
            lblApplicationName.BackColor = chkDarkMode.BackColor = Common.MainColor;
            btnCategories.ForeColor = btnProducts.ForeColor = btnUsers.ForeColor = btnLogout.ForeColor = Common.ButtonTextColor;
            panelTop.BackColor = panelSideBar.BackColor = panelFooter.BackColor = Common.BackgroundColorDark;

            BackColor = ddlMetal.BackColor = ddlCategory.BackColor = Common.BackgroundColor;
            lblApplicationName.ForeColor = ddlMetal.ForeColor = ddlCategory.ForeColor = lblTime.ForeColor = chkDarkMode.ForeColor = Common.LabelColor;
        }

        private void ddlMetal_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockChart();
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockChart();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new Users().Show();
            Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new Customers().Show();
            Hide();
        }

        private void btnKittyRegistration_Click(object sender, EventArgs e)
        {
            new KittyRegistration().Show();
            Hide();
        }

        private void btnKittyInstallment_Click(object sender, EventArgs e)
        {
            new KittyInstallment().Show();
            Hide();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
                Common.IsDarkMode = true;
            else
                Common.IsDarkMode = false;

            if (Common.IsDarkMode)
            {
                Common.MainColor = Color.FromArgb(255, 72, 1);
                Common.MainColorDark = Color.FromArgb(170, 48, 0);
                Common.BackgroundColor = Color.FromArgb(64, 64, 64);
                Common.BackgroundColorDark = Color.FromArgb(45, 45, 45);
                Common.LabelColor = Color.White;
                Common.ButtonTextColor = Color.Black;
            }
            else
            {
                Common.MainColor = Color.FromArgb(26, 106, 149);
                Common.MainColorDark = Color.FromArgb(17, 81, 115);
                Common.BackgroundColor = Color.FromArgb(119, 161, 183);
                Common.BackgroundColorDark = Color.FromArgb(29, 44, 59);
                Common.LabelColor = Color.White;
                Common.ButtonTextColor = Color.Black;
            }

            InitializeColors();
        }             
    }
}
