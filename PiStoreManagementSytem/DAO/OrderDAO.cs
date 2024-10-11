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
    }
}
