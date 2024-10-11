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

        public bool AddNewEmployee(string name, string email, string password, string phone, string address, decimal salary, DateTime hireDate)
        {
            string query = "INSERT INTO Employee (Name, Email, Password, Phone, Address, Salary, HireDate) VALUES (@Name, @Email, @Password, @Phone, @Address, @Salary, @HireDate)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
                new SqlParameter("@Salary", salary),
                new SqlParameter("@HireDate", hireDate)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CheckPhoneNumberExist(string phone)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @Phone";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Phone", phone)
            };

            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return count > 0;
        }

        public bool CheckEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Email = @Email";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return count > 0;
        }

        public bool DeleteEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE ID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateEmployee(int id, string name, string email, string phone, string address, decimal salary, DateTime hireDate)
        {
            string query = "UPDATE Employee " +
                           "SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, Salary = @Salary, HireDate = @HireDate " +
                           "WHERE ID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
                new SqlParameter("@Salary", salary),
                new SqlParameter("@HireDate", hireDate)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool CheckCurrentPassword(int id, string currentPassword)
        {
            string query = "SELECT Password FROM Employee WHERE ID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                string storedPassword = result.Rows[0]["Password"].ToString();
                return storedPassword == currentPassword;
            }

            return false;
        }

        public bool UpdatePassword(int id, string newPassword)
        {
            string query = "UPDATE Employee SET Password = @NewPassword WHERE ID = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NewPassword", newPassword),
                new SqlParameter("@Id", id)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public Employee GetEmployeeById(int id)
        {
            string query = "SELECT * FROM Employee WHERE ID = @id";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@id", id) });

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                Employee employee = new Employee(row);
                return employee;
            }

            return null; 
        }

    }
}
