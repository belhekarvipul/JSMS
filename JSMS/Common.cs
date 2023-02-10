using JSMS.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSMS
{
    public static class Common
    {
        public static int LoggedInUserId = 0;
        public static string LoggedInUserName = string.Empty;
        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
        public static string ApplicationShortName = ConfigurationManager.AppSettings["ApplicationShortName"];
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public const string SelectText = "-- Select --";

        #region Color Theme
        public static bool IsDarkMode = false;
        public static Color MainColor = Color.FromArgb(26, 106, 149);
        public static Color MainColorDark = Color.FromArgb(17, 81, 115);
        public static Color BackgroundColor = Color.FromArgb(119, 161, 183);
        public static Color BackgroundColorDark = Color.FromArgb(29, 44, 59);
        public static Color LabelColor = Color.White;
        public static Color ButtonTextColor = Color.Black;
        #endregion

        public enum Roles
        {
            Admin,
            Salesman
        }

        public enum Metal
        {
            Gold,
            Silver,
            Platinum
        }

        public static void LogException(Exception ex)
        {
            throw ex;
        }

        public static void LoadCategories(ComboBox ddlCategory)
        {
            DataSet ds = new DAL().GetCategories();
            ddlCategory.Items.Clear();
            DataRow row = ds.Tables[0].NewRow();
            row["Name"] = SelectText;
            row["ID"] = 0;
            ds.Tables[0].Rows.InsertAt(row, 0);
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DisplayMember = "Name";
            ddlCategory.ValueMember = "ID";
        }
        public static void LoadMetal(ComboBox ddlMetal)
        {
            ddlMetal.Items.Clear();
            ddlMetal.Items.Add(SelectText);
            foreach (var metal in Enum.GetNames(typeof(Metal)))
            {
                ddlMetal.Items.Add(metal);
            }
            ddlMetal.SelectedIndex = 0;
        }

        public static bool GetDeleteConfirmation()
        {
            return MessageBox.Show("Do you really want to delete selected record?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
    }
}
