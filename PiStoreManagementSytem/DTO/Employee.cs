using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DTO
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {

        }

        public Employee(int iD, string name, string email, string phone, string address, decimal salary, DateTime hireDate)
        {
            ID = iD;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            Salary = salary;
            HireDate = hireDate;
        }

        public Employee(int iD, string name, string email, string password, string phone, string address, decimal salary, DateTime hireDate)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            Salary = salary;
            HireDate = hireDate;
        }

        public Employee(DataRow row) 
        {
            ID = (int)row["ID"];
            Name = (string)row["Name"];
            Email = (string)row["Email"];
            Password = (string)row["Password"];
            Phone = (string)row["Phone"];
            Address = (string)row["Address"];
            Salary = (Decimal)row["Salary"];
            HireDate = (DateTime)row["HireDate"];
        }
    }
}
