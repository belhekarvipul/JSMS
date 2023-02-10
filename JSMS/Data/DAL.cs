using System;
using System.Data;

namespace JSMS.Data
{
    public class DAL
    {
        #region Product
        public DataSet GetProducts()
        {
            DataSet dsProducts = new DataSet();
            try
            {
                string query = "SELECT P.ProductId AS [Product ID] , P.Name, P.Description, C.Name AS Category, P.Metal, P.Price, P.Stock FROM Products P " +
                    "LEFT OUTER JOIN Categories C ON P.Category = C.CategoryId ORDER BY P.Name";
                dsProducts = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsProducts;
        }

        public int SaveProduct(int productId, string name, string description, string price, string stock, int categoryId, string metal)
        {
            int result = 0;
            try
            {
                string query;
                if (productId > 0)
                    query = $"Update Products SET " +
                        $"Name = '{name}', " +
                        $"Description = '{description}', " +
                        $"Price = '{price}', " +
                        $"Stock = '{stock}', " +
                        $"Category = {categoryId}, " +
                        $"Metal = '{metal}', " +
                        $"LastModifiedBy = {Common.LoggedInUserId}, LastModifiedDate = {DateTime.Now.ToShortDateString()}" +
                        $" WHERE ProductId = {productId}";
                else
                    query = "INSERT INTO Products (Name, Description, Price, Stock, Category, Metal, LastModifiedBy, LastModifiedDate) VALUES " +
                        $"('{name}','{description}','{price}','{stock}',{categoryId},'{metal}', {Common.LoggedInUserId}, {DateTime.Now.ToShortDateString()})";

                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }

            return result;
        }

        public int DeleteProduct(int productId)
        {
            int result = 0;
            try
            {
                string query = "DELETE FROM Products WHERE ProductId = " + productId;
                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return result;
        }
        #endregion

        #region Category
        public DataSet GetCategories()
        {
            DataSet dsCategories = new DataSet();
            try
            {
                string query = "SELECT CategoryId as ID, Name, Description FROM Categories ORDER BY Name";
                dsCategories = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsCategories;
        }

        public int SaveCategory(int categoryId, string name, string description)
        {
            int result = 0;
            try
            {
                string query;
                if (categoryId > 0)
                    query = $"UPDATE Categories SET " +
                        $"Name = '{name}', " +
                        $"Description = '{description}', " +
                        $"LastModifiedBy = {Common.LoggedInUserId}, LastModifiedDate = {DateTime.Now.ToShortDateString()} " +
                        $"WHERE CategoryId = {categoryId}";
                else
                    query = $"INSERT INTO Categories (Name, Description, LastModifiedBy, LastModifiedDate) VALUES " +
                        $"('{name}','{description}', {Common.LoggedInUserId}, {DateTime.Now.ToShortDateString()})";

                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }

            return result;
        }

        public int DeleteCategory(int categoryId)
        {
            int result = 0;
            try
            {
                string query = "DELETE FROM Categories WHERE CategoryId = " + categoryId;
                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return result;
        }
        #endregion

        #region User
        public DataSet Login(string loginId, string password, string role)
        {
            DataSet dsUser = new DataSet();
            try
            {
                string query = $"SELECT TOP 1 Name, UserId FROM Users WHERE LoginId = '{loginId}' AND [Password] = '{password}' AND Role = '{role}'";
                dsUser = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsUser;
        }

        public DataSet GetUsers()
        {
            DataSet dsUsers = new DataSet();
            try
            {
                string query = "SELECT UserId, Name, LoginId AS [Login Id], Role, [Password] FROM Users ORDER BY Name";
                dsUsers = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsUsers;
        }

        public int SaveUser(int userId, string name, string loginId, string password, string role)
        {
            int result = 0;
            try
            {
                string query;
                if (userId > 0)
                    query = $"UPDATE Users SET " +
                        $"Name = '{name}', " +
                        $"LoginId = '{loginId}', " +
                        $"[Password] = '{password}', " +
                        $"Role = '{role}', " +
                        $"LastModifiedBy = {Common.LoggedInUserId}, LastModifiedDate = {DateTime.Now.ToShortDateString()} " +
                        $"WHERE UserId = {userId}";
                else
                    query = $"INSERT INTO Users (Name, LoginId, [Password], Role, LastModifiedBy, LastModifiedDate) VALUES " +
                        $"('{name}','{loginId}','{password}','{role}', {Common.LoggedInUserId}, {DateTime.Now.ToShortDateString()})";

                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }

            return result;
        }

        public int DeleteUser(int userId)
        {
            int result = 0;
            try
            {
                string query = "DELETE FROM Users WHERE UserId = " + userId;
                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return result;
        }
        #endregion

        #region Charts
        public DataSet GetCurrentStocksData(string metal, string CategoryId)
        {
            DataSet dsCurrentStocks = new DataSet();
            try
            {
                string query = "SELECT P.Name, P.Stock AS Stock FROM Products P " +
                    "LEFT OUTER JOIN Categories C ON P.Category = C.CategoryId " +
                    $"WHERE ('{metal}' = '0' OR P.Metal = '{metal}') " +
                    $"AND ('{CategoryId}' = '0' OR P.Category = {int.Parse(CategoryId)}) " +
                    $"ORDER BY P.Name";
                dsCurrentStocks = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsCurrentStocks;
        }
        #endregion
    }
}
