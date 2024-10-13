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
    public class ClientDAO
    {
        private static ClientDAO instance;

        public static ClientDAO Instance
        {
            get { if (instance == null) instance = new ClientDAO(); return instance; }
            private set { instance = value; }
        }

        private ClientDAO() { }

        public List<Client> LoadClientList()
        {
            List<Client> clients = new List<Client>();

            string query = "SELECT * FROM dbo.Client";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Client c = new Client(item);
                clients.Add(c);
            }

            return clients;
        }

        public DataTable LoadClientTable()
        {
            string query = "SELECT * FROM dbo.Client";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddNewClient(string name, string email, string phone, string address)
        {
            string query = "INSERT INTO Client (Name, Email, Phone, Address) VALUES (@Name, @Email, @Phone, @Address)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CheckPhoneNumberExist(string phone)
        {
            string query = "SELECT COUNT(*) FROM Client WHERE Phone = @Phone";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Phone", phone)
            };

            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return count > 0;
        }

        public bool CheckEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM Client WHERE Email = @Email";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return count > 0;
        }

        public bool UpdateClient(int id, string name, string email, string phone, string address)
        {
            string query = "UPDATE Client " +
                           "SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address " +
                           "WHERE ID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteClient(int id)
        {
            string query = "DELETE FROM Client WHERE ID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CanDeleteClient(int clientID)
        {
            bool hasOrders = false;

            string query = "SELECT COUNT(*) FROM [Order] WHERE ClientID = @ClientID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", clientID)
            };

            int orderCount = (int)DataProvider.Instance.ExecuteScalar(query, parameters);

            if (orderCount > 0)
            {
                hasOrders = true;
            }
            return !hasOrders;
        }

    }
}
