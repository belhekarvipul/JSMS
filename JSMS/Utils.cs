//using log4net;
//using log4net.Config;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace JSMS
{
    public static class Utils
    {
        private static string EncryptionKey = new Regex("[^a-zA-Z0-9]").Replace(Common.ApplicationName, "");
        //private static readonly ILog log = LogManager.GetLogger(typeof(Utils));

        static Utils()
        {
            if (!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }
            //XmlConfigurator.Configure();
        }

        public static void LogException(Exception ex)
        {
            //log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
            MessageBox.Show("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
        }

        public static string Encrypt(string inputString)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(inputString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    inputString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return inputString;
        }

        public static string Decrypt(string inputString)
        {
            byte[] cipherBytes = Convert.FromBase64String(inputString.Replace(" ", "+"));
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    inputString = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return inputString;
        }

        public static bool Print(string printer, string text)
        {
            if (printer != null)
            {
                try
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrinterSettings.PrinterName = printer;
                    pd.PrintPage += new PrintPageEventHandler((sender, e) => new PrintUtils().PrintPage(sender, e, text));
                    pd.Print();
                    return true;
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    public class PrintUtils
    {
        public void PrintPage(object sender, PrintPageEventArgs ev, string text)
        {
            try
            {
                //Get the Graphics object  
                Graphics g = ev.Graphics;

                //Create a font Arial with size 16  
                Font font = new Font("Arial", 16);

                //Create a solid brush with black color  
                SolidBrush brush = new SolidBrush(Color.Black);

                //Draw "Hello Printer!";  
                g.DrawString(text,
                font, brush,
                new Rectangle(20, 20, 200, 100));
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
        }
    }
}
