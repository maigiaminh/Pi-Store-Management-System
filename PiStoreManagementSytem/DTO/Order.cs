using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DTO
{
    public class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {

        }

        public Order(int iD, int clientID, int employeeID, DateTime date, decimal totalPrice)
        {
            ID = iD;
            ClientID = clientID;
            EmployeeID = employeeID;
            OrderDate = date;
            TotalPrice = totalPrice;
        }

        public Order(DataRow row) 
        {
            ID = (int)row["ID"];
            ClientID = (int)row["ClientID"];
            EmployeeID = (int)row["EmployeeID"];
            OrderDate = (DateTime)row["OrderDate"];
            TotalPrice = (decimal)row["TotalPrice"];
        }
    }
}
