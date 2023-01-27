using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSMS
{
    public static class Common
    {
        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static void LogException(Exception ex)
        {
            //TODO
        }
    }
}
