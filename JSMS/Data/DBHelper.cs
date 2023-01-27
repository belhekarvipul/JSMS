using System;
using System.Data;
using System.Data.OleDb;

namespace JSMS.Data
{
    public class DBHelper
    {
        private OleDbConnection GetConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = Common.ConnectionString;
            return connection;
        }

        public static DataSet ExecuteSelect(string query)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection connection = new DBHelper().GetConnection())
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                try
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return ds;
            }
        }
    }
}
