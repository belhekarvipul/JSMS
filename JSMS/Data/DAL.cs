using System;
using System.Data;

namespace JSMS.Data
{
    public class DAL
    {
        public DataSet GetProducts()
        {
            DataSet dsProducts = new DataSet();
            try
            {
                string query = "SELECT * FROM Products";
                dsProducts = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Common.LogException(ex);
            }
            return dsProducts;
        }

        public DataSet GetCategories()
        {
            DataSet dsCategories = new DataSet();
            try
            {
                string query = "SELECT * FROM Categories";
                dsCategories = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Common.LogException(ex);
            }
            return dsCategories;
        }
    }
}
