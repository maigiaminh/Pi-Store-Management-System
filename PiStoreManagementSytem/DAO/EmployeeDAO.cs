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
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        private EmployeeDAO() { }

        public List<Employee> LoadEmployeeList()
        {
            List<Employee> employees = new List<Employee>();

            string query = "SELECT * FROM dbo.Employee";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Employee e = new Employee(item);
                employees.Add(e);
            }

            return employees;
        }

        public DataTable LoadEmployeeTable()
        {
            string query = "SELECT * FROM dbo.Employee";

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

    }
}
