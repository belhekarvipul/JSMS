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
                    query = "Update Products SET " +
                        "Name = '" + name + "', " +
                        "Description = '" + description + "', " +
                        "Price = '" + price + "', " +
                        "Stock = '" + stock + "', " +
                        "Category = " + categoryId + ", " +
                        "Metal = '" + metal + "', " +
                        "LastModifiedBy = " + Common.LoggedInUserId + ", LastModifiedDate = " + DateTime.Now.ToShortDateString() +
                        " WHERE ProductId = " + productId;
                else
                    query = "INSERT INTO Products (Name, Description, Price, Stock, Category, Metal, LastModifiedBy, LastModifiedDate) VALUES " +
                        "('" + name + "','" + description + "','" + price + "','" + stock + "'," + categoryId + ",'" + metal + "', " + Common.LoggedInUserId + ", " + DateTime.Now.ToShortDateString() + ")";

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
                    query = "UPDATE Categories SET " +
                        "Name = '" + name + "', " +
                        "Description = '" + description + "', " +
                        "LastModifiedBy = " + Common.LoggedInUserId + ", LastModifiedDate = " + DateTime.Now.ToShortDateString() + " " +
                        "WHERE CategoryId = " + categoryId + "";
                else
                    query = "INSERT INTO Categories (Name, Description, LastModifiedBy, LastModifiedDate) VALUES " +
                        "('" + name + "','" + description + "', " + Common.LoggedInUserId + ", " + DateTime.Now.ToShortDateString() + ")";

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
                string query = "SELECT TOP 1 Name, UserId FROM Users WHERE LoginId = '" + loginId + "' AND [Password] = '" + password + "' AND Role = '" + role + "'";
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
                    query = "UPDATE Users SET " +
                        "Name = '" + name + "', " +
                        "LoginId = '" + loginId + "', " +
                        "[Password] = '" + password + "', " +
                        "Role = '" + role + "', " +
                        "LastModifiedBy = " + Common.LoggedInUserId + ", LastModifiedDate = " + DateTime.Now.ToShortDateString() + " " +
                        "WHERE UserId = " + userId + "";
                else
                    query = "INSERT INTO Users (Name, LoginId, [Password], Role, LastModifiedBy, LastModifiedDate) VALUES " +
                        "('" + name + "','" + loginId + "','" + password + "','" + role + "', " + Common.LoggedInUserId + ", " + DateTime.Now.ToShortDateString() + ")";

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

        #region Customer
        public DataSet GetCustomers()
        {
            DataSet dsCustomers = new DataSet();
            try
            {
                string query = "SELECT CustomerId, CustomerName, ContactNumber, Address, PanNumber FROM Customers ORDER BY CustomerName";
                dsCustomers = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsCustomers;
        }

        public int SaveCustomer(int customerId, string customerName, string contactNumber, string address, string pan)
        {
            int result = 0;
            try
            {
                string query;
                if (customerId > 0)
                    query = "UPDATE Customers SET " +
                        "CustomerName = '" + customerName + "', " +
                        "ContactNumber = '" + contactNumber + "', " +
                        "Address = '" + address + "', " +
                        "PanNumber = '" + pan + "', " +
                        "LastModifiedBy = " + Common.LoggedInUserId + ", LastModifiedDate = " + DateTime.Now.ToShortDateString() + " " +
                        "WHERE CustomerId = " + customerId + "";
                else
                    query = "INSERT INTO Customers (CustomerName, ContactNumber, Address, PanNumber, LastModifiedBy, LastModifiedDate) VALUES " +
                        "('" + customerName + "','" + contactNumber + "','" + address + "','" + pan + "'," + Common.LoggedInUserId + ", " + DateTime.Now.ToShortDateString() + ")";

                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }

            return result;
        }

        public int DeleteCustomer(int customerId)
        {
            int result = 0;
            try
            {
                string query = "DELETE FROM Customers WHERE CustomerId = " + customerId;
                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return result;
        }
        #endregion

        #region Kitty Registration
        public DataSet GetKittyRegistration()
        {
            DataSet dsRegistrations = new DataSet();
            try
            {
                string query = "SELECT KR.RegistrationId, C.CustomerName, C.ContactNumber, KR.Amount, KR.StartDate, KR.EndDate, KR.TotalAmount, KR.ToalGoldBooked " +
                "FROM KittyRegistration KR INNER JOIN Customers C ON KR.CustomerId = C.CustomerId " +
                "ORDER BY C.CustomerName";
                dsRegistrations = DBHelper.ExecuteSelect(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }
            return dsRegistrations;
        }

        public int SaveKittyRegistration(int customerId, string amount, string StartDate, string EndDate, string goldBooked)
        {
            int result = 0;
            try
            {
                string query = "INSERT INTO KittyRegistration (CustomerId, Amount, StartDate, EndDate, TotalAmount, ToalGoldBooked, LastModifiedBy, LastModifiedDate) VALUES " +
                        "(" + customerId + ",'" + amount + "', '" + StartDate + "', '" + EndDate + "', " + amount + ", " + goldBooked + ", " + Common.LoggedInUserId + ", " + DateTime.Now.ToShortDateString() + ")";

                result = DBHelper.Execute(query);
            }
            catch (Exception ex)
            {
                Utils.LogException(ex);
            }

            return result;
        }

        public int DeleteKittyRegistrations(int registrationId)
        {
            int result = 0;
            try
            {
                string query = "DELETE FROM KittyRegistration WHERE RegistrationId = " + registrationId;
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
                    "WHERE ('" + metal + "' = '0' OR P.Metal = '" + metal + "') " +
                    "AND ('" + CategoryId + "' = '0' OR P.Category = " + int.Parse(CategoryId) + ") " +
                    "ORDER BY P.Name";
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
