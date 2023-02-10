using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace JSMS
{
    public static class Utils
    {
        private static string EncryptionKey = new Regex("[^a-zA-Z0-9]").Replace(Common.ApplicationName, "");
        private static readonly ILog log = LogManager.GetLogger(typeof(Utils));

        static Utils()
        {
            if (!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }
            XmlConfigurator.Configure();
        }

        public static void LogException(Exception ex)
        {
            log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
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
    }
}
