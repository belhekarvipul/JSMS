﻿using JSMS.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            InitializeColors();
            Text = Common.ApplicationShortName + ": Sales";
            dateTimer.Start();
            Reset();
            //LoadSales();
        }

        #region Private Methods
        //private void LoadSales()
        //{
        //    DataSet ds = new DAL().GetSales();
        //    dataGridSales.DataSource = ds.Tables[0];
        //}
        private void Reset()
        {
            lblCategoryId.Text = "0";
            txtCategory.Text = string.Empty;
            txtCategory.Focus();
            txtDescription.Text = string.Empty;
            lblResult.Text = string.Empty;
        }

        private void InitializeColors()
        {
            panelSideBarMain.BackColor = Common.MainColorDark;
            lblFormName.BackColor = Common.MainColor;
            btnNew.ForeColor = btnSave.ForeColor = btnDelete.ForeColor = Common.ButtonTextColor;
            panelTop.BackColor = panelSideBar.BackColor = panelFooter.BackColor = Common.BackgroundColorDark;

            BackColor = txtCategory.BackColor = txtDescription.BackColor = dataGridSales.BackgroundColor = Common.BackgroundColor;
            lblFormName.ForeColor = lblResult.ForeColor = lblTime.ForeColor = lblId.ForeColor = lblCategoryId.ForeColor = lblId.ForeColor = lblName.ForeColor = lblDesc.ForeColor = txtCategory.ForeColor = txtDescription.ForeColor = Common.LabelColor;
        }
        #endregion

        #region EVENTS
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCategory.Text))
            //{
            //    int result = new DAL().SaveCategory(int.Parse(lblCategoryId.Text), txtCategory.Text, txtDescription.Text);
            //    if (result > 0)
            //    {
            //        Reset();
            //        lblResult.Text = "Category saved successfully.";
            //        LoadSales();
            //    }
            //    else
            //        lblResult.Text = "Failed to save category.";
            //}
            //else
            //{
            //    lblResult.Text = "Fields with * are mandatory.";
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Common.GetDeleteConfirmation())
            //{
            //    var selectedRows = dataGridSales.SelectedRows;
            //    if (selectedRows.Count > 0)
            //    {

            //        lblResult.Text = string.Empty;
            //        int result = new DAL().DeleteCategory(int.Parse(selectedRows[0].Cells[0].Value.ToString()));

            //        if (result > 0)
            //        {
            //            Reset();
            //            lblResult.Text = "Category deleted successfully.";
            //            LoadSales();
            //        }
            //        else
            //            lblResult.Text = "Failed to delete category.";
            //    }
            //    else
            //        lblResult.Text = "Please select a record.";
            //}
        }

        private void dataGridSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedRows = dataGridSales.SelectedRows;
            //if (selectedRows.Count > 0)
            //{
            //    lblResult.Text = string.Empty;
            //    lblCategoryId.Text = selectedRows[0].Cells[0].Value.ToString();
            //    txtCategory.Text = selectedRows[0].Cells[1].Value.ToString();
            //    txtDescription.Text = selectedRows[0].Cells[2].Value.ToString();
            //}
        }

        private void dataGridSales_Sorted(object sender, EventArgs e)
        {
            //Reset();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MMM/yyyy - hh:mm:ss tt");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Dashboard().Show();
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
