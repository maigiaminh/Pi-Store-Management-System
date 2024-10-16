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
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set { instance = value; }
        }

        private OrderDAO() { }

        public DataTable LoadOrderTableByClientID(int id)
        {
            string query = "SELECT ID, OrderDate, TotalPrice FROM [Order] WHERE ClientID = @ClientID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", id)
            };

            DataTable recentOrders = DataProvider.Instance.ExecuteQuery(query, parameters);

            return recentOrders;
        }

        public DataTable LoadOrderTable()
        {
            string query = @"
            SELECT 
                O.ID,
                E.ID AS EmployeeID,
                E.Name AS EmployeeName,
                C.Name AS ClientName,
                C.Phone AS ClientPhone,
                O.OrderDate,
                O.TotalPrice
            FROM 
                [Order] O
            JOIN 
                Client C ON O.ClientID = C.ID
            JOIN 
                Employee E ON O.EmployeeID = E.ID";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int AddNewOrder(int clientID, int employeeID, DateTime orderDate, decimal totalPrice)
        {
            string query = @"
            INSERT INTO [Order] (ClientID, EmployeeID, OrderDate, TotalPrice)
            VALUES (@ClientID, @EmployeeID, @OrderDate, @TotalPrice);
            SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", clientID),
                new SqlParameter("@EmployeeID", employeeID),
                new SqlParameter("@OrderDate", orderDate),
                new SqlParameter("@TotalPrice", totalPrice)
            };

            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
        }

        public Order GetOrderByID(int id)
        {
            string query = "SELECT * FROM [Order] WHERE ID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            Order o = new Order(data.Rows[0]);
            return o;
        }
    }
}
