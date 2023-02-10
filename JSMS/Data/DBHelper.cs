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
                    Utils.LogException(ex);
                }
                finally
                {
                    connection.Close();
                }
                return ds;
            }
        }

        public static int Execute(string query)
        {
            int result = 0;
            using (OleDbConnection connection = new DBHelper().GetConnection())
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = query;
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Utils.LogException(ex);
                }
                return result;
            }
        }
    }
}
