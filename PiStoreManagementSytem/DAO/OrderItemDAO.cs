using Microsoft.Data.SqlClient;
using PiStoreManagementSytem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DAO
{
    public class OrderItemDAO
    {
        private static OrderItemDAO instance;

        public static OrderItemDAO Instance
        {
            get { if (instance == null) instance = new OrderItemDAO(); return instance; }
            private set { instance = value; }
        }

        private OrderItemDAO() { }

        public DataTable LoadOrderItemByID(int id)
        {
            string query = @"SELECT P.Name AS ProductName, OI.Quantity 
                     FROM OrderItem OI 
                     JOIN Product P ON OI.ProductID = P.ID 
                     WHERE OI.OrderID = @OrderID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", id)
            };

            DataTable recentOrders = DataProvider.Instance.ExecuteQuery(query, parameters);

            return recentOrders;
        }

        public DataTable LoadOrderItemTable()
        {
            string query = @"SELECT P.Name AS ProductName, OI.Quantity 
                     FROM OrderItems OI 
                     JOIN Product P ON OI.ProductID = P.ID 
                     WHERE OI.OrderID = @OrderID";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void AddOrderItem(int orderID, int productID, int quantity)
        {
            string query = @"
            INSERT INTO OrderItem (OrderID, ProductID, Quantity)
            VALUES (@OrderID, @ProductID, @Quantity)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID),
                new SqlParameter("@ProductID", productID),
                new SqlParameter("@Quantity", quantity),
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);

            UpdateProductQuantity(productID, quantity);
        }

        public void UpdateProductQuantity(int productID, int quantitySold)
        {
            string query = @"
                UPDATE Product 
                SET Quantity = Quantity - @QuantitySold 
                WHERE ID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuantitySold", quantitySold),
                new SqlParameter("@ProductID", productID)
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetOrderItemsByOrderID(int orderID)
        {
            string query = @"
                SELECT P.Name AS ProductName, OI.Quantity, (P.Price * OI.Quantity) AS TotalPrice
                FROM OrderItem OI
                JOIN Product P ON OI.ProductID = P.ID
                WHERE OI.OrderID = @OrderID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID)
            };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
