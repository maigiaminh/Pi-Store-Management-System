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
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public int AddNewBill(int orderID, int clientID, int employeeID, DateTime billDate, decimal totalPrice)
        {
            string query = @"
                INSERT INTO Bill (OrderID, ClientID, EmployeeID, BillDate, TotalPrice)
                VALUES (@OrderID, @ClientID, @EmployeeID, @BillDate, @TotalPrice);
                SELECT SCOPE_IDENTITY();"; 

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@OrderID", orderID),
            new SqlParameter("@ClientID", clientID),
            new SqlParameter("@EmployeeID", employeeID),
            new SqlParameter("@BillDate", billDate),
            new SqlParameter("@TotalPrice", totalPrice)
            };

            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
        }

        public bool IsBillExistByOrderID(int orderID)
        {
            string query = "SELECT COUNT(*) FROM Bill WHERE OrderID = @OrderID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@OrderID", orderID)
            };

            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));

            return count > 0;
        }
    }
}
