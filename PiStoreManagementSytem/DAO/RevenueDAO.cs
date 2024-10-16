using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PiStoreManagementSytem.DAO
{
    public class RevenueDAO
    {
        private static RevenueDAO instance;

        public static RevenueDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RevenueDAO();
                return instance;
            }
        }

        private RevenueDAO() { }

        public DataTable GetMonthlyRevenue()
        {
            string query = @"
                SELECT 
                    DATENAME(MONTH, OrderDate) AS [Month],
                    SUM(TotalPrice) AS Revenue
                FROM [Order]
                GROUP BY DATENAME(MONTH, OrderDate), MONTH(OrderDate)
                ORDER BY MONTH(OrderDate)";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
