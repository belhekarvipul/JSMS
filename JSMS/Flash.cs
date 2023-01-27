using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace JSMS
{
    public partial class Flash : Form
    {
        int progressMaxSize = 650;
        public Flash()
        {
            InitializeComponent();
            lblApplicationName.Text = Common.ApplicationName;
            lblApplicationName.TextAlign = ContentAlignment.MiddleCenter;
            progressPanel.Width = 0;
            progressTimer.Start();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressPanel.Width < progressMaxSize)
            {
                progressPanel.Width++;
                lblProgress.Text = "(" + (progressPanel.Width * 100 / progressMaxSize) + "%)";
            }
            else
            {
                progressTimer.Stop();
                Hide();
                new Login().Show();
            }
        }
    }
}
