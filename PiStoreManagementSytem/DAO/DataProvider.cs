using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=PiStoreDB;Integrated Security=True;Encrypt=False";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                connection.Close();

            }
            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                data = cmd.ExecuteNonQuery();
                connection.Close();

            }
            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                data = cmd.ExecuteScalar();
                connection.Close();

            }
            return data;
        }
    }
}
