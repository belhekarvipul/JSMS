namespace JSMS
{
    partial class SampleForm
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
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.pTitleSideBar = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pTitleBackButton = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.pTitleName = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pTobBar = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.pFormSideBar = new System.Windows.Forms.Panel();
            this.pGridPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTitleBackButton.SuspendLayout();
            this.pTitleName.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitleSideBar
            // 
            this.pTitleSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.pTitleSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTitleSideBar.Font = new System.Drawing.Font("Arial", 10F);
            this.pTitleSideBar.Location = new System.Drawing.Point(0, 0);
            this.pTitleSideBar.Name = "pTitleSideBar";
            this.pTitleSideBar.Size = new System.Drawing.Size(15, 50);
            this.pTitleSideBar.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pTitleBackButton
            // 
            this.pTitleBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.pTitleBackButton.Controls.Add(this.btnBack);
            this.pTitleBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTitleBackButton.Font = new System.Drawing.Font("Arial", 10F);
            this.pTitleBackButton.Location = new System.Drawing.Point(15, 0);
            this.pTitleBackButton.Name = "pTitleBackButton";
            this.pTitleBackButton.Size = new System.Drawing.Size(50, 50);
            this.pTitleBackButton.TabIndex = 1;
            // 
            // lblFormName
            // 
            this.lblFormName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(0, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFormName.Size = new System.Drawing.Size(705, 50);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "label1";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pTitleName
            // 
            this.pTitleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.pTitleName.Controls.Add(this.lblFormName);
            this.pTitleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTitleName.Font = new System.Drawing.Font("Arial", 10F);
            this.pTitleName.Location = new System.Drawing.Point(65, 0);
            this.pTitleName.Name = "pTitleName";
            this.pTitleName.Size = new System.Drawing.Size(818, 50);
            this.pTitleName.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pTitleName);
            this.panel3.Controls.Add(this.pTitleBackButton);
            this.panel3.Controls.Add(this.pTitleSideBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Arial", 10F);
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 50);
            this.panel3.TabIndex = 1;
            // 
            // pTobBar
            // 
            this.pTobBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pTobBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTobBar.Font = new System.Drawing.Font("Arial", 10F);
            this.pTobBar.Location = new System.Drawing.Point(0, 0);
            this.pTobBar.Name = "pTobBar";
            this.pTobBar.Size = new System.Drawing.Size(883, 15);
            this.pTobBar.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResult.Font = new System.Drawing.Font("Arial", 10F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(491, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(219, 30);
            this.lblResult.TabIndex = 19;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.Font = new System.Drawing.Font("Arial", 10F);
            this.btnNew.Location = new System.Drawing.Point(710, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 30);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSave.Location = new System.Drawing.Point(767, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDelete.Location = new System.Drawing.Point(824, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTime.Size = new System.Drawing.Size(250, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00/00/0000 00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pFormSideBar
            // 
            this.pFormSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pFormSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFormSideBar.Font = new System.Drawing.Font("Arial", 10F);
            this.pFormSideBar.Location = new System.Drawing.Point(0, 0);
            this.pFormSideBar.Name = "pFormSideBar";
            this.pFormSideBar.Size = new System.Drawing.Size(15, 340);
            this.pFormSideBar.TabIndex = 4;
            // 
            // pGridPanel
            // 
            this.pGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridPanel.Font = new System.Drawing.Font("Arial", 10F);
            this.pGridPanel.Location = new System.Drawing.Point(0, 207);
            this.pGridPanel.Name = "pGridPanel";
            this.pGridPanel.Size = new System.Drawing.Size(868, 133);
            this.pGridPanel.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tableLayoutPanel1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Font = new System.Drawing.Font("Arial", 10F);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(868, 207);
            this.panel11.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 207);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pGridPanel);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Font = new System.Drawing.Font("Arial", 10F);
            this.panel10.Location = new System.Drawing.Point(15, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(868, 340);
            this.panel10.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.pFormSideBar);
            this.panel7.Controls.Add(this.pFooter);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Arial", 10F);
            this.panel7.Location = new System.Drawing.Point(0, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(883, 370);
            this.panel7.TabIndex = 2;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pFooter.Controls.Add(this.lblResult);
            this.pFooter.Controls.Add(this.btnNew);
            this.pFooter.Controls.Add(this.btnSave);
            this.pFooter.Controls.Add(this.btnDelete);
            this.pFooter.Controls.Add(this.lblTime);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Font = new System.Drawing.Font("Arial", 10F);
            this.pFooter.Location = new System.Drawing.Point(0, 340);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(883, 30);
            this.pFooter.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pTobBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 435);
            this.panel1.TabIndex = 1;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 435);
            this.Controls.Add(this.panel1);
            this.Name = "SampleForm";
            this.Text = "Form1";
            this.pTitleBackButton.ResumeLayout(false);
            this.pTitleName.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel pTitleSideBar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pTitleBackButton;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Panel pTitleName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pTobBar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pFormSideBar;
        private System.Windows.Forms.Panel pGridPanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}