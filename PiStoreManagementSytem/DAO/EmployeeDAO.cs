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
            string query = $"INSERT INTO Employee (Name, Email, Password, Phone, Address, Salary, HireDate) VALUES (N'{name}', '{email}', '{password}', '{phone}', N'{address}', '{salary}', '{hireDate}')";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
