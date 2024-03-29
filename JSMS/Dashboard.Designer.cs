﻿namespace JSMS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.panelSideBarMain = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.chartDataByMetal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.ddlMetal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnKittyInstallment = new System.Windows.Forms.Button();
            this.btnKittyRegistration = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataByMetal)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(0, 41);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(207, 41);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Location = new System.Drawing.Point(0, 0);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(207, 41);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTime.Size = new System.Drawing.Size(261, 32);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTop.Controls.Add(this.panel4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(913, 13);
            this.panelTop.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 13);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.chkDarkMode);
            this.panel2.Controls.Add(this.lblApplicationName);
            this.panel2.Controls.Add(this.panelSideBarMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 65);
            this.panel2.TabIndex = 4;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkDarkMode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkMode.Location = new System.Drawing.Point(817, 0);
            this.chkDarkMode.Margin = new System.Windows.Forms.Padding(2);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(96, 65);
            this.chkDarkMode.TabIndex = 5;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(13, 0);
            this.lblApplicationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(900, 65);
            this.lblApplicationName.TabIndex = 4;
            this.lblApplicationName.Text = "Application Name";
            this.lblApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSideBarMain
            // 
            this.panelSideBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.panelSideBarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBarMain.Location = new System.Drawing.Point(0, 0);
            this.panelSideBarMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideBarMain.Name = "panelSideBarMain";
            this.panelSideBarMain.Size = new System.Drawing.Size(13, 65);
            this.panelSideBarMain.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelFooter.Controls.Add(this.lblTime);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 417);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(913, 32);
            this.panelFooter.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panelSideBar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 78);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(913, 339);
            this.panel7.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(221, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(692, 339);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(692, 305);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(380, 305);
            this.panel12.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.chartDataByMetal);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 111);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(380, 194);
            this.panel14.TabIndex = 7;
            // 
            // chartDataByMetal
            // 
            this.chartDataByMetal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartDataByMetal.ChartAreas.Add(chartArea1);
            this.chartDataByMetal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDataByMetal.Legends.Add(legend1);
            this.chartDataByMetal.Location = new System.Drawing.Point(0, 0);
            this.chartDataByMetal.Margin = new System.Windows.Forms.Padding(2);
            this.chartDataByMetal.Name = "chartDataByMetal";
            this.chartDataByMetal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.chartDataByMetal.Series.Add(series1);
            this.chartDataByMetal.Size = new System.Drawing.Size(380, 194);
            this.chartDataByMetal.TabIndex = 0;
            this.chartDataByMetal.Text = "chart1";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.ddlCategory);
            this.panel13.Controls.Add(this.ddlMetal);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 111);
            this.panel13.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Products Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metal";
            // 
            // ddlCategory
            // 
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(205, 53);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(145, 24);
            this.ddlCategory.TabIndex = 2;
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCategory_SelectedIndexChanged);
            // 
            // ddlMetal
            // 
            this.ddlMetal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMetal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMetal.FormattingEnabled = true;
            this.ddlMetal.Location = new System.Drawing.Point(25, 53);
            this.ddlMetal.Margin = new System.Windows.Forms.Padding(2);
            this.ddlMetal.Name = "ddlMetal";
            this.ddlMetal.Size = new System.Drawing.Size(145, 24);
            this.ddlMetal.TabIndex = 1;
            this.ddlMetal.SelectedIndexChanged += new System.EventHandler(this.ddlMetal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(220, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 339);
            this.panel9.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnKittyInstallment);
            this.panel6.Controls.Add(this.btnKittyRegistration);
            this.panel6.Controls.Add(this.btnCustomers);
            this.panel6.Controls.Add(this.btnUsers);
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.btnProducts);
            this.panel6.Controls.Add(this.btnCategories);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(13, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 339);
            this.panel6.TabIndex = 3;
            // 
            // btnKittyInstallment
            // 
            this.btnKittyInstallment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKittyInstallment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKittyInstallment.Location = new System.Drawing.Point(0, 205);
            this.btnKittyInstallment.Margin = new System.Windows.Forms.Padding(2);
            this.btnKittyInstallment.Name = "btnKittyInstallment";
            this.btnKittyInstallment.Size = new System.Drawing.Size(207, 41);
            this.btnKittyInstallment.TabIndex = 6;
            this.btnKittyInstallment.Text = "Kitty Installment";
            this.btnKittyInstallment.UseVisualStyleBackColor = true;
            this.btnKittyInstallment.Click += new System.EventHandler(this.btnKittyInstallment_Click);
            // 
            // btnKittyRegistration
            // 
            this.btnKittyRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKittyRegistration.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKittyRegistration.Location = new System.Drawing.Point(0, 164);
            this.btnKittyRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnKittyRegistration.Name = "btnKittyRegistration";
            this.btnKittyRegistration.Size = new System.Drawing.Size(207, 41);
            this.btnKittyRegistration.TabIndex = 5;
            this.btnKittyRegistration.Text = "Kitty Registration";
            this.btnKittyRegistration.UseVisualStyleBackColor = true;
            this.btnKittyRegistration.Click += new System.EventHandler(this.btnKittyRegistration_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(0, 123);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(207, 41);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(0, 82);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(207, 41);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 298);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 41);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(13, 339);
            this.panelSideBar.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(913, 449);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDataByMetal)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSideBarMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataByMetal;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.ComboBox ddlMetal;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnKittyRegistration;
        private System.Windows.Forms.Button btnKittyInstallment;
    }
}