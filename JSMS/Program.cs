using System;
using System.Windows.Forms;

namespace JSMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (Common.IsDevEnv == "1")
                {
                    Common.LoggedInUserId = 1;
                    Common.LoggedInUserName = "Admin";
                    Application.Run(new Dashboard());
                }
                else {
                    Application.Run(new Flash());
                }                
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
        }
    }
}
