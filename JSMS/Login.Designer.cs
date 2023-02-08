namespace JSMS
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.panelSideBarMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.imgApplicationLogo = new System.Windows.Forms.PictureBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioSales = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgApplicationLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblApplicationName);
            this.panel1.Controls.Add(this.panelSideBarMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 0;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.lblApplicationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(10, 0);
            this.lblApplicationName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(790, 79);
            this.lblApplicationName.TabIndex = 1;
            this.lblApplicationName.Text = "Application Name";
            this.lblApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSideBarMain
            // 
            this.panelSideBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.panelSideBarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBarMain.Location = new System.Drawing.Point(0, 0);
            this.panelSideBarMain.Name = "panelSideBarMain";
            this.panelSideBarMain.Size = new System.Drawing.Size(10, 79);
            this.panelSideBarMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.radioAdmin);
            this.panel2.Controls.Add(this.radioSales);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtLoginId);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblLoginId);
            this.panel2.Controls.Add(this.panelSideBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 301);
            this.panel2.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.lblError.Location = new System.Drawing.Point(290, 238);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(189, 23);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Incorrect credentials";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(502, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(624, 224);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.imgApplicationLogo);
            this.panel9.Location = new System.Drawing.Point(12, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 305);
            this.panel9.TabIndex = 11;
            // 
            // imgApplicationLogo
            // 
            this.imgApplicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgApplicationLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgApplicationLogo.Image = global::JSMS.Properties.Resources.ApplicationLogoLarge;
            this.imgApplicationLogo.InitialImage = global::JSMS.Properties.Resources.ApplicationLogoLarge;
            this.imgApplicationLogo.Location = new System.Drawing.Point(0, 0);
            this.imgApplicationLogo.Name = "imgApplicationLogo";
            this.imgApplicationLogo.Size = new System.Drawing.Size(253, 305);
            this.imgApplicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgApplicationLogo.TabIndex = 8;
            this.imgApplicationLogo.TabStop = false;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.ForeColor = System.Drawing.Color.White;
            this.radioAdmin.Location = new System.Drawing.Point(620, 177);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(89, 27);
            this.radioAdmin.TabIndex = 3;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioSales
            // 
            this.radioSales.AutoSize = true;
            this.radioSales.Checked = true;
            this.radioSales.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSales.ForeColor = System.Drawing.Color.White;
            this.radioSales.Location = new System.Drawing.Point(502, 177);
            this.radioSales.Name = "radioSales";
            this.radioSales.Size = new System.Drawing.Size(84, 27);
            this.radioSales.TabIndex = 2;
            this.radioSales.TabStop = true;
            this.radioSales.Text = "Sales";
            this.radioSales.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(271, -5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 312);
            this.panel8.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(502, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // txtLoginId
            // 
            this.txtLoginId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginId.ForeColor = System.Drawing.Color.White;
            this.txtLoginId.Location = new System.Drawing.Point(502, 54);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(207, 30);
            this.txtLoginId.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(354, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.ForeColor = System.Drawing.Color.White;
            this.lblLoginId.Location = new System.Drawing.Point(354, 57);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(83, 23);
            this.lblLoginId.TabIndex = 1;
            this.lblLoginId.Text = "Login ID";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(10, 301);
            this.panelSideBar.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelFooter.Controls.Add(this.linkLabel1);
            this.panelFooter.Controls.Add(this.lblDevelopedBy);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 380);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 70);
            this.panelFooter.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(1)))));
            this.linkLabel1.Location = new System.Drawing.Point(419, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 70);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vipul Belhekar";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDevelopedBy.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopedBy.ForeColor = System.Drawing.Color.White;
            this.lblDevelopedBy.Location = new System.Drawing.Point(0, 0);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(419, 70);
            this.lblDevelopedBy.TabIndex = 0;
            this.lblDevelopedBy.Text = "Designed and Developed by";
            this.lblDevelopedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgApplicationLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelSideBarMain;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox imgApplicationLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioSales;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDevelopedBy;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblError;
    }
}